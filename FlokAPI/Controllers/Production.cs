using FlokAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace FlokAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductionController : ControllerBase
{
  private readonly FlokAPIContext _db;

  public ProductionController(FlokAPIContext db)
  {
    _db = db;
  }




}