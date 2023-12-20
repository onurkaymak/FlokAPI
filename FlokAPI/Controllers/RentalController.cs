using FlokAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System;


namespace FlokAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RentalController : ControllerBase
{
  private readonly FlokAPIContext _db;
  private readonly UserManager<ApplicationUser> _userManager;

  public RentalController(FlokAPIContext db, UserManager<ApplicationUser> userManager)
  {
    _db = db;
    _userManager = userManager;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<RentalService>>> Get(int rentalServiceId, string customerEmail, string customerPhoneNum)
  {
    IQueryable<RentalService> query = _db.RentalServices.AsQueryable();

    try
    {
      if (rentalServiceId > 0)
      {
        query = query.Where(entry => entry.RentalServiceId == rentalServiceId);
      }

      if (customerEmail != null)
      {
        Customer customer = await _db.Customers.FirstOrDefaultAsync(c => c.Email == customerEmail);
        query = query.Where(entry => entry.CustomerId == customer.CustomerId)
                     .Include(e => e.Vehicle);
      }

      if (customerPhoneNum != null)
      {
        Customer customer = await _db.Customers.FirstOrDefaultAsync(c => c.PhoneNum == customerPhoneNum);
        query = query.Where(entry => entry.CustomerId == customer.CustomerId)
                     .Include(e => e.Vehicle);
      }

      return await query.ToListAsync();

    }
    catch
    {
      return BadRequest();
    }
  }


  [HttpPost]
  public async Task<ActionResult<RentalService>> Post(RentalServiceDto rentalInfo)
  {
    try
    {
      Customer customer = await _db.Customers.FirstOrDefaultAsync(c => c.Email == rentalInfo.CustomerEmail);
      Vehicle vehicle = await _db.Vehicles.FirstOrDefaultAsync(v => v.VIN == rentalInfo.VIN);

      if (vehicle == null || customer == null)
      {
        throw new Exception("Vehicle or customer not found, please try again.");
      }

      if (vehicle.InProduction == true)
      {
        throw new Exception("This vehicle is in production, please try again later.");
      }

#nullable enable
      RentalService? joinEntity = _db.RentalServices.FirstOrDefault(join => (join.VehicleId == vehicle.VehicleId));
#nullable disable

      if (joinEntity == null)
      {
        _db.RentalServices.Add(new RentalService()
        {
          VehicleId = vehicle.VehicleId,
          CustomerId = customer.CustomerId,
          ServiceAgentId = rentalInfo.ServiceAgentId,
          ReservationStart = DateTime.Parse(rentalInfo.ReservationStart, System.Globalization.CultureInfo.InvariantCulture),
          ReservationEnd = DateTime.Parse(rentalInfo.ReservationEnd, System.Globalization.CultureInfo.InvariantCulture)
        });

        vehicle.IsRented = true;

        _db.Vehicles.Update(vehicle);

        await _db.SaveChangesAsync();
      }
      else
      {
        throw new Exception("This vehicle has been rented already.");
      }

      return Ok(new { status = "success", message = "You successfully booked this vehicle.", vehicle = vehicle, customer = customer, serviceAgent = rentalInfo.ServiceAgentId });
    }
    catch (Exception ex)
    {
      return BadRequest(new { status = "error", message = ex.Message });
    }
  }


  [HttpPut("{rentalServiceId}")]
  public async Task<IActionResult> Put(int rentalServiceId, RentalServiceUpdateDto updatedRentalService)
  {
    if (rentalServiceId != updatedRentalService.RentalServiceId)
    {
      return BadRequest();
    }

    try
    {
      RentalService rentalService = await _db.RentalServices.FirstOrDefaultAsync(s => s.RentalServiceId == updatedRentalService.RentalServiceId);

      rentalService.ReservationStart = DateTime.Parse(updatedRentalService.ReservationStart, System.Globalization.CultureInfo.InvariantCulture);
      rentalService.ReservationEnd = DateTime.Parse(updatedRentalService.ReservationEnd, System.Globalization.CultureInfo.InvariantCulture);

      _db.RentalServices.Update(rentalService);

      await _db.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!RentalServiceExists(rentalServiceId))
      {
        return NotFound();
      }
      else
      {
        throw;
      }
    }
    return NoContent();
  }

  private bool RentalServiceExists(int rentalServiceId)
  {
    return _db.RentalServices.Any(e => e.RentalServiceId == rentalServiceId);
  }


  [HttpDelete("{rentalServiceId}")]
  public async Task<IActionResult> DeleteRentalService(int rentalServiceId)
  {
    RentalService rentalService = await _db.RentalServices.FindAsync(rentalServiceId);
    Vehicle vehicle = await _db.Vehicles.FirstOrDefaultAsync(v => v.VehicleId == rentalService.VehicleId);

    if (rentalService == null || vehicle == null)
    {
      return NotFound();
    }

    _db.RentalServices.Remove(rentalService);
    vehicle.IsRented = false;
    _db.Vehicles.Update(vehicle);
    await _db.SaveChangesAsync();

    return Ok(new { status = "success", message = "The vehicle deleted from the rented car list.", vehicle = vehicle });
  }

}