using FlokAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace FlokAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FleetController : ControllerBase
{
  private readonly FlokAPIContext _db;

  public FleetController(FlokAPIContext db)
  {
    _db = db;
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

}