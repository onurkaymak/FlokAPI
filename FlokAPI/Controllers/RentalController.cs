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
        query = query.Where(entry => entry.CustomerId == customer.CustomerId);
      }

      if (customerPhoneNum != null)
      {
        Customer customer = await _db.Customers.FirstOrDefaultAsync(c => c.PhoneNum == customerPhoneNum);
        query = query.Where(entry => entry.CustomerId == customer.CustomerId);
      }

      return await query.ToListAsync();
    }
    catch
    {
      return BadRequest();
    }
  }


}