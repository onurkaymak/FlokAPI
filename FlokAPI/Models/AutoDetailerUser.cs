using Microsoft.AspNetCore.Identity;

namespace FlokAPI.Models
{
  public class AutoDetailerUser : ApplicationUser
  {

    public string EmployeeRole { get; set; }
    public int DetailedVehicle { get; set; }

  }
}