using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace FlokAPI.Models
{
  public class FlokAPIContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<DetailingService> DetailingServices { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public FlokAPIContext(DbContextOptions<FlokAPIContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Customer>()
  .HasData(
     new Customer { CustomerId = 1, Name = "Carla Johns", Email = "carlajohns@gmail.com", PhoneNum = "618-452-8417" },
     new Customer { CustomerId = 2, Name = "Martin Castillo", Email = "mcastillo@outlook.com", PhoneNum = "860-254-7331" },
     new Customer { CustomerId = 3, Name = "Vincent Cooper", Email = "vincentcooper85@gmail.com", PhoneNum = "841-318-9338" },
     new Customer { CustomerId = 4, Name = "Nora Olsen", Email = "cras.eget@protonmail.org", PhoneNum = "880-547-6442" },
     new Customer { CustomerId = 5, Name = "Sasha Roman", Email = "primis.in@yahoo.ca", PhoneNum = "686-168-5402" },
     new Customer { CustomerId = 6, Name = "Erich Booker", Email = "sit.amet@outlook.com", PhoneNum = "686-107-2226" },
     new Customer { CustomerId = 7, Name = "Philip Guzman", Email = "amet.consectetuer@protonmail.edu", PhoneNum = "231-874-7758" },
     new Customer { CustomerId = 8, Name = "Tucker Wright", Email = "mauris@google.net", PhoneNum = "823-205-3788" },
     new Customer { CustomerId = 9, Name = "Jessica Mendoza", Email = "jessmendoza@gmail.com", PhoneNum = "632-627-4811" },
     new Customer { CustomerId = 10, Name = "Kevin Holt", Email = "iaculis.nec@outlook.edu", PhoneNum = "277-175-1424" }
  );
      base.OnModelCreating(builder);
    }


  }
}