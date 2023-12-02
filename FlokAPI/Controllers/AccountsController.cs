using Microsoft.AspNetCore.Identity;
using FlokAPI.Models;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace FlockAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{
  private readonly UserManager<ApplicationUser> _userManager;
  private readonly SignInManager<ApplicationUser> _signInManager;
  private readonly IConfiguration _configuration;
  private readonly RoleManager<IdentityRole> _roleManager;

  public AccountsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration, RoleManager<IdentityRole> roleManager)
  {
    _userManager = userManager;
    _signInManager = signInManager;
    _configuration = configuration;
    _roleManager = roleManager;
  }


  [HttpPost("register")]
  public async Task<IActionResult> Register([FromBody] RegisterDto user)
  {
    await CreateRoles();


    var userExists = await _userManager.FindByEmailAsync(user.Email);

    if (userExists != null)
    {
      return BadRequest(new { status = "error", message = "Email already exists" });
    }

    var newUser = new ApplicationUser()
    {
      Email = user.Email,
      UserName = user.UserName,
      Role = user.Role
    };

    var result = await _userManager.CreateAsync(newUser, user.Password);


    if (result.Succeeded)
    {
      await _userManager.AddToRoleAsync(newUser, user.Role);

      return Ok(new { status = "success", message = "User has been successfully created" });
    }
    else
    {
      return BadRequest(result.Errors);
    }
  }


  private async Task CreateRoles()
  {
    // This method iterates through an array of role names and checks if the role already exists with RoleExistsAsync method. 
    // If the role does not exist, it creates the role using CreateAsync method.

    string[] roleNames = { "Auto Detailer", "Customer Service Agent", "Manager" };

    foreach (var roleName in roleNames)
    {
      var roleExist = await _roleManager.RoleExistsAsync(roleName);

      if (!roleExist)
      {
        await _roleManager.CreateAsync(new IdentityRole(roleName));
      }
    }
  }



}