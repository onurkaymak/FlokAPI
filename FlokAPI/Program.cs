using FlokAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FlokAPIContext>(
                  dbContextOptions => dbContextOptions
                    .UseMySql(
                      builder.Configuration["ConnectionStrings:DefaultConnection"],
                      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
                  )
                );

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<FlokAPIContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
{
  options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
  options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
  options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
  options.SaveToken = true;
  options.RequireHttpsMetadata = false;
  options.TokenValidationParameters = new TokenValidationParameters()
  {
    ValidateIssuer = true,
    ValidateAudience = true,
    ValidAudience = builder.Configuration["JWT:ValidAudience"],
    ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
  };
});

builder.Services.AddCors(p => p.AddPolicy("corspolicy", builder =>
{
  builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddControllers()
.AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
  var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
  var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
  var db = scope.ServiceProvider.GetRequiredService<FlokAPIContext>();

  await db.Database.MigrateAsync();

  // Ensure roles exist
  string[] roles = { "MANAGER", "AUTO DETAILER", "CUSTOMER SERVICE AGENT" };
  foreach (var role in roles)
  {
    if (!await roleManager.RoleExistsAsync(role))
      await roleManager.CreateAsync(new IdentityRole(role));
  }

  // Seed Manager
  if (await userManager.FindByEmailAsync("manager@flok.com") == null)
  {
    var manager = new ApplicationUser
    {
      Id = FlokAPIContext.ManagerId,
      UserName = "Lucas",
      Email = "manager@flok.com",
      EmployeeRole = "MANAGER",
      SecurityStamp = Guid.NewGuid().ToString()
    };
    await userManager.CreateAsync(manager, "Flok1234!");
    await userManager.AddToRoleAsync(manager, "MANAGER");
  }

  // Seed Detailer 1
  if (await userManager.FindByEmailAsync("detailer1@flok.com") == null)
  {
    var detailer1 = new ApplicationUser
    {
      Id = FlokAPIContext.Detailer1Id,
      UserName = "Jonathan",
      Email = "detailer1@flok.com",
      EmployeeRole = "AUTO DETAILER",
      SecurityStamp = Guid.NewGuid().ToString()
    };
    await userManager.CreateAsync(detailer1, "Flok1234!");
    await userManager.AddToRoleAsync(detailer1, "AUTO DETAILER");
  }

  // Seed Detailer 2
  if (await userManager.FindByEmailAsync("detailer2@flok.com") == null)
  {
    var detailer2 = new ApplicationUser
    {
      Id = FlokAPIContext.Detailer2Id,
      UserName = "James",
      Email = "detailer2@flok.com",
      EmployeeRole = "AUTO DETAILER",
      SecurityStamp = Guid.NewGuid().ToString()
    };
    await userManager.CreateAsync(detailer2, "Flok1234!");
    await userManager.AddToRoleAsync(detailer2, "AUTO DETAILER");
  }

  // Seed Customer Service Agent
  if (await userManager.FindByEmailAsync("agent@flok.com") == null)
  {
    var agent = new ApplicationUser
    {
      Id = FlokAPIContext.AgentId,
      UserName = "Marry",
      Email = "agent@flok.com",
      EmployeeRole = "CUSTOMER SERVICE AGENT",
      SecurityStamp = Guid.NewGuid().ToString()
    };
    await userManager.CreateAsync(agent, "Flok1234!");
    await userManager.AddToRoleAsync(agent, "CUSTOMER SERVICE AGENT");
  }

  try
  {
    if (!db.DetailingServices.Any())
    {
      db.DetailingServices.AddRange(
        new DetailingService { VehicleId = 2, DetailerId = FlokAPIContext.Detailer1Id, CreatedAt = DateTime.UtcNow.Date.AddHours(9) },
        new DetailingService { VehicleId = 3, DetailerId = FlokAPIContext.Detailer1Id, CreatedAt = DateTime.UtcNow.Date.AddHours(10) },
        new DetailingService { VehicleId = 5, DetailerId = FlokAPIContext.Detailer1Id, CreatedAt = DateTime.UtcNow.Date.AddHours(11) },
        new DetailingService { VehicleId = 6, DetailerId = FlokAPIContext.Detailer2Id, CreatedAt = DateTime.UtcNow.Date.AddHours(9) },
        new DetailingService { VehicleId = 7, DetailerId = FlokAPIContext.Detailer2Id, CreatedAt = DateTime.UtcNow.Date.AddHours(10) }
      );
      await db.SaveChangesAsync();
    }

    if (!db.RentalServices.Any())
    {
      db.RentalServices.AddRange(
        new RentalService { VehicleId = 1, CustomerId = 1, ServiceAgentId = FlokAPIContext.AgentId, ReservationStart = new DateTime(2026, 4, 1, 9, 0, 0), ReservationEnd = new DateTime(2026, 4, 7, 9, 0, 0) },
        new RentalService { VehicleId = 4, CustomerId = 3, ServiceAgentId = FlokAPIContext.AgentId, ReservationStart = new DateTime(2026, 4, 3, 10, 0, 0), ReservationEnd = new DateTime(2026, 4, 10, 10, 0, 0) },
        new RentalService { VehicleId = 2, CustomerId = 5, ServiceAgentId = FlokAPIContext.AgentId, ReservationStart = new DateTime(2026, 3, 20, 8, 0, 0), ReservationEnd = new DateTime(2026, 3, 25, 8, 0, 0) }
      );
      await db.SaveChangesAsync();
    }
  }
  catch (Exception ex)
  {
    Console.WriteLine($"Seeding warning: {ex.Message}");
  }
}

app.UseCors("corspolicy");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();