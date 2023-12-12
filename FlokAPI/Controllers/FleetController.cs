using FlokAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace FlokAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FleetController : ControllerBase
{
  private readonly FlokAPIContext _db;
  private readonly UserManager<ApplicationUser> _userManager;

  public FleetController(FlokAPIContext db, UserManager<ApplicationUser> userManager)
  {
    _db = db;
    _userManager = userManager;
  }


  [HttpGet]
  [Authorize(Roles = "MANAGER")]
  public async Task<ActionResult<IEnumerable<Vehicle>>> Get(string VIN, string isRented, string inProduction)
  {
    IQueryable<Vehicle> query = _db.Vehicles.AsQueryable();

    try
    {
      if (VIN != null)
      {
        query = query.Where(entry => entry.VIN == VIN);
      }

      if (isRented == "true")
      {
        query = query.Where(entry => entry.IsRented == true);
      }
      else if (isRented == "false")
      {
        query = query.Where(entry => entry.IsRented == false);
      }

      if (inProduction == "true")
      {
        query = query.Where(entry => entry.InProduction == true);

      }
      else if (inProduction == "false")
      {
        query = query.Where(entry => entry.InProduction == false);
      }

      return await query.ToListAsync();
    }
    catch
    {
      return BadRequest();
    }
  }


  [HttpPost]
  [Authorize(Roles = "MANAGER")]
  public async Task<ActionResult<Vehicle>> Post(Vehicle vehicle)
  {
    _db.Vehicles.Add(vehicle);
    await _db.SaveChangesAsync();
    return Ok(new { status = "success", message = "Vehicle added into the inventory.", vehicle = vehicle });
  }


  [HttpPut("{id}")]
  [Authorize(Roles = "MANAGER")]
  public async Task<IActionResult> Put(int id, Vehicle vehicle)
  {
    if (id != vehicle.VehicleId)
    {
      return BadRequest();
    }

    try
    {
      _db.Vehicles.Update(vehicle);

      await _db.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!VehicleExists(id))
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

  private bool VehicleExists(int id)
  {
    return _db.Vehicles.Any(e => e.VehicleId == id);
  }


  [HttpDelete("{id}")]
  [Authorize(Roles = "MANAGER")]
  public async Task<IActionResult> DeleteVehicle(int id)
  {
    Vehicle vehicle = await _db.Vehicles.FindAsync(id);
    if (vehicle == null)
    {
      return NotFound();
    }

    _db.Vehicles.Remove(vehicle);
    await _db.SaveChangesAsync();

    return Ok(new { status = "success", message = "Vehicle deleted from the inventory.", vehicle = vehicle });
  }


  [HttpPost]
  [Route("AddDetailingService")]
  public async Task<ActionResult<DetailingService>> AddDetailingService(DetailingServiceDto serviceInfo)
  {
    try
    {
      Vehicle vehicle = await _db.Vehicles.FirstOrDefaultAsync(v => v.VIN == serviceInfo.VIN);
      ApplicationUser user = await _userManager.FindByIdAsync(serviceInfo.DetailerId);

      if (vehicle == null || user == null)
      {
        throw new Exception("Vehicle or user not found, please try again.");
      }

#nullable enable
      DetailingService? joinEntity = _db.DetailingServices.FirstOrDefault(join => (join.VehicleId == vehicle.VehicleId));
#nullable disable

      if (joinEntity == null)
      {
        _db.DetailingServices.Add(new DetailingService() { VehicleId = vehicle.VehicleId, DetailerId = user.Id });

        vehicle.InProduction = true;

        _db.Vehicles.Update(vehicle);

        await _db.SaveChangesAsync();
      }
      else
      {
        throw new Exception("This vehicle have been cleaned already.");
      }

      return Ok(new { status = "success", message = "You started to clean this vehicle.", VehicleVIN = vehicle.VIN, DetailerId = user.Id });
    }
    catch (Exception ex)
    {
      return BadRequest(new { status = "error", message = ex.Message });
    }
  }


  [HttpDelete]
  [Route("DeleteDetailingService")]
  public async Task<ActionResult<DetailingService>> DeleteDetailingService(DetailingServiceDto serviceInfo)
  {
    try
    {
      Vehicle vehicle = await _db.Vehicles.FirstOrDefaultAsync(v => v.VIN == serviceInfo.VIN);
      ApplicationUser user = await _userManager.FindByIdAsync(serviceInfo.DetailerId);
      DetailingService service = await _db.DetailingServices.FirstOrDefaultAsync(s => s.VehicleId == vehicle.VehicleId);

      if (vehicle == null || user == null || service == null)
      {
        throw new Exception("Something went wrong, please try again.");
      }

#nullable enable
      DetailingService? joinEntity = _db.DetailingServices.FirstOrDefault(join => (join.DetailingServiceId == service.DetailingServiceId));
#nullable disable

      if (joinEntity != null)
      {
        _db.DetailingServices.Remove(service);

        vehicle.InProduction = false;

        _db.Vehicles.Update(vehicle);

        user.TotalDetailing = user.TotalDetailing + 1;

        await _userManager.UpdateAsync(user);

        await _db.SaveChangesAsync();
      }
      else
      {
        throw new Exception("Cannot find any record of this service.");
      }

      return Ok(new { status = "success", message = "You finished cleaning of this vehicle.", VehicleVIN = vehicle.VIN, DetailerId = user.Id });
    }
    catch (Exception ex)
    {
      return BadRequest(new { status = "error", message = ex.Message });
    }
  }


}