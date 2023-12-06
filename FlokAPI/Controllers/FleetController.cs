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

  [HttpPost]
  public async Task<ActionResult<Vehicle>> Post(Vehicle vehicle)
  {
    _db.Vehicles.Add(vehicle);
    await _db.SaveChangesAsync();
    return Ok(new { status = "success", message = "Vehicle added into the inventory.", vehicle = vehicle });
  }
}