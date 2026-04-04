namespace FlokAPI.Models
{
  public class DetailingService
  {
    public int DetailingServiceId { get; set; }
    public int VehicleId { get; set; }
    public Vehicle Vehicle { get; set; } // reference navigation property
    public string DetailerId { get; set; }
    public ApplicationUser Detailer { get; set; } // reference navigation property
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
  }
}