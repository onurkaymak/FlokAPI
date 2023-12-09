namespace FlokAPI.Models
{
  public class DetailingService // Join Entity
  {
    public int DetailingServiceId { get; set; }
    public int VehicleId { get; set; }
    public Vehicle Vehicle { get; set; } // reference navigation property
    public ApplicationUser Detailer { get; set; } // reference navigation property
  }
}