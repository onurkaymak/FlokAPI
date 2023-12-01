using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace FlokAPI.Models
{
  public class FlokAPIContext : IdentityDbContext<ApplicationUser>
  {

    public FlokAPIContext(DbContextOptions<FlokAPIContext> options) : base(options)
    {

    }



  }
}