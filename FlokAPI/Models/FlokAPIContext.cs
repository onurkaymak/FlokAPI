using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace FlokAPI.Models
{
  public class FlokAPIContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<DetailingService> DetailingServices { get; set; }

    public FlokAPIContext(DbContextOptions<FlokAPIContext> options) : base(options)
    {

    }



  }
}