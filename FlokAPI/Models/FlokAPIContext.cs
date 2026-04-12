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
    public DbSet<RentalService> RentalServices { get; set; }

    public FlokAPIContext(DbContextOptions<FlokAPIContext> options) : base(options)
    {
    }

    // Fixed GUIDs for seeded users so we can reference them in DetailingServices
    public static readonly string ManagerId = "a1b2c3d4-0000-0000-0000-000000000001";
    public static readonly string Detailer1Id = "a1b2c3d4-0000-0000-0000-000000000002";
    public static readonly string Detailer2Id = "a1b2c3d4-0000-0000-0000-000000000003";
    public static readonly string AgentId = "a1b2c3d4-0000-0000-0000-000000000004";

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      // Seed Customers
      builder.Entity<Customer>().HasData(
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

      // Seed Vehicles
      builder.Entity<Vehicle>().HasData(
        new Vehicle { VehicleId = 1, VIN = "TH829472", Make = "Honda", Model = "Civic", Color = "White", Mileage = 32000, Class = "Standard", ClassCode = "SCAR", State = "OR", LicensePlate = "OR732", IsRented = true },
        new Vehicle { VehicleId = 2, VIN = "SC232043", Make = "Toyota", Model = "Corolla", Color = "Black", Mileage = 18500, Class = "Standard", ClassCode = "SCAR", State = "IL", LicensePlate = "IL773", IsRented = false },
        new Vehicle { VehicleId = 3, VIN = "ST212765", Make = "Chevrolet", Model = "Malibu", Color = "Silver", Mileage = 45200, Class = "Full-Size", ClassCode = "FCAR", State = "CO", LicensePlate = "CO292", IsRented = false },
        new Vehicle { VehicleId = 4, VIN = "TK939284", Make = "Chevrolet", Model = "Spark", Color = "Blue", Mileage = 27800, Class = "Economy", ClassCode = "ECAR", State = "WA", LicensePlate = "WA729", IsRented = true },
        new Vehicle { VehicleId = 5, VIN = "SR563809", Make = "BMW", Model = "4-Series", Color = "Gray", Mileage = 221, Class = "Luxury Convertible", ClassCode = "LTAR", State = "CA", LicensePlate = "CA728", IsRented = false },
        new Vehicle { VehicleId = 6, VIN = "LT281943", Make = "Ford", Model = "F-150", Color = "Red", Mileage = 39500, Class = "Large Pickup", ClassCode = "PPAR", State = "OR", LicensePlate = "OR621", IsRented = false },
        new Vehicle { VehicleId = 7, VIN = "SR938384", Make = "Hyundai", Model = "Santa Fe", Color = "Black", Mileage = 52000, Class = "Standard SUV", ClassCode = "SFAR", State = "CA", LicensePlate = "CA728", IsRented = false },
        new Vehicle { VehicleId = 8, VIN = "LK291013", Make = "Toyota", Model = "Rav4", Color = "White", Mileage = 29000, Class = "Intermediate SUV", ClassCode = "IFAR", State = "OR", LicensePlate = "OR612", IsRented = false },
        new Vehicle { VehicleId = 9, VIN = "HG637920", Make = "Dodge", Model = "Challenger", Color = "Black", Mileage = 22100, Class = "Sport", ClassCode = "SSAR", State = "OR", LicensePlate = "OR212", IsRented = false },
        new Vehicle { VehicleId = 10, VIN = "RG587984", Make = "Nissan", Model = "Frontier", Color = "White", Mileage = 3587, Class = "Small Pickup", ClassCode = "SPAR", State = "WA", LicensePlate = "WA875", IsRented = false },
        new Vehicle { VehicleId = 11, VIN = "TC627912", Make = "Jeep", Model = "Wrangler", Color = "Red", Mileage = 22587, Class = "Jeep Wrangler", ClassCode = "FJAR", State = "CA", LicensePlate = "CA212", IsRented = false },
        new Vehicle { VehicleId = 12, VIN = "RR292721", Make = "Chrysler", Model = "Pacifica", Color = "Gray", Mileage = 12634, Class = "Minivan", ClassCode = "MVAR", State = "OR", LicensePlate = "OR973", IsRented = false }
      );
    }
  }
}