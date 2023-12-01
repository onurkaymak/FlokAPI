using Microsoft.AspNetCore.Identity;
using FlokAPI.Models;
using System.Threading.Tasks;

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