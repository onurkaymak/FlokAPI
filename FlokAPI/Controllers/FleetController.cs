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
  public async Task<ActionResult<IEnumerable<Vehicle>>> Get(int VIN, string isRented, string inProduction)
  {
    IQueryable<Vehicle> query = _db.Vehicles.AsQueryable();

    try
    {
      if (VIN != 0)
      {
        query = query.Where(entry => entry.VIN == VIN);
      }

      if (isRented == "true")
      {
        query = query.Where(entry => entry.IsRented == true);
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
}