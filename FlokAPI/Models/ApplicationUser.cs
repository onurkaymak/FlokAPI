using Microsoft.AspNetCore.Identity;

namespace FlokAPI.Models
{
  public class ApplicationUser : IdentityUser
  {

    public string Role { get; set; }

  }
}