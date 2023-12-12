using Microsoft.AspNetCore.Identity;

namespace FlokAPI.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string EmployeeRole { get; set; }
    public int TotalDetailing { get; set; }
    public List<DetailingService> JoinEntities { get; } // collection navigation property.
    public List<RentalService> RentalJoinEntities { get; } // collection navigation property.
  }
}