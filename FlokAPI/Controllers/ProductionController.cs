using FlokAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace FlokAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductionController : ControllerBase
{
  private readonly FlokAPIContext _db;
  private readonly UserManager<ApplicationUser> _userManager;

  public ProductionController(FlokAPIContext db, UserManager<ApplicationUser> userManager)
  {
    _db = db;
    _userManager = userManager;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<DetailingService>>> Get()
  {
    try
    {
      List<DetailingService> detailingServices = await _db.DetailingServices
        .Include(e => e.Vehicle)
        .Include(e => e.Detailer)
        .ToListAsync();

      return Ok(detailingServices);
    }
    catch (Exception ex)
    {
      return BadRequest(new { status = "error", message = ex.Message });
    }
  }

  [HttpGet("leaderboard")]
  public async Task<ActionResult> GetLeaderboard()
  {
    try
    {
      var leaderboard = await _db.DetailingServices
        .Where(s => s.CreatedAt.Date == DateTime.UtcNow.Date)
        .Include(s => s.Detailer)
        .GroupBy(s => new { s.DetailerId, s.Detailer.UserName })
        .Select(g => new { Name = g.Key.UserName, Count = g.Count() })
        .OrderByDescending(g => g.Count)
        .ToListAsync();

      return Ok(new { status = "success", leaderboard });
    }
    catch (Exception ex)
    {
      return BadRequest(new { status = "error", message = ex.Message });
    }
  }

  [HttpPost]
  public async Task<ActionResult> Post(DetailingServiceDto detailingInfo)
  {
    try
    {
      Vehicle vehicle = await _db.Vehicles.FirstOrDefaultAsync(v => v.VIN == detailingInfo.VIN);
      ApplicationUser detailer = await _userManager.FindByIdAsync(detailingInfo.DetailerId);

      if (vehicle == null)
      {
        throw new Exception("Vehicle not found. Please check the VIN and try again.");
      }

      if (detailer == null)
      {
        throw new Exception("Detailer not found. Please try again.");
      }

      _db.DetailingServices.Add(new DetailingService()
      {
        VehicleId = vehicle.VehicleId,
        DetailerId = detailer.Id,
        CreatedAt = DateTime.UtcNow
      });

      await _db.SaveChangesAsync();

      return Ok(new { status = "success", message = "Vehicle scan recorded successfully.", vehicle = vehicle, detailer = detailer });
    }
    catch (Exception ex)
    {
      return BadRequest(new { status = "error", message = ex.Message });
    }
  }
}