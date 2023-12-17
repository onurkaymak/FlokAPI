using FlokAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

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

  // ??? Get All Pending Detailings
  [HttpGet("{id}")] // Get pending detailing records for the specific detailer.
  public async Task<ActionResult<IEnumerable<DetailingService>>> Get(string id)
  {
    ApplicationUser user = await _userManager.FindByIdAsync(id);

    IQueryable<DetailingService> query = _db.DetailingServices.AsQueryable();

    try
    {
      if (user != null)
      {
        query = query.Where(entry => entry.DetailerId == user.Id);
        // .Include(entry => entry.Detailer);
      }

      return await query.ToListAsync();
    }
    catch
    {
      return BadRequest();
    }
  }


  [HttpGet] // Get pending detailing records for the specific detailer.
  [Route("GetTotal/{id}")]
  public async Task<ActionResult<IEnumerable<DetailingService>>> GetTotal(string id)
  {
    try
    {
      ApplicationUser user = await _userManager.FindByIdAsync(id);

      if (user == null)
      {
        throw new Exception("Cannot find any record of this service.");
      }

      return Ok(new { status = "success", message = "Number of the vehicle you have detailed today.", Total = user.TotalDetailing });
    }
    catch (Exception ex)
    {
      return BadRequest(new { status = "error", message = ex.Message });
    }
  }

}