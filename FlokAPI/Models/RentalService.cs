namespace FlokAPI.Models
{
  public class RentalService // Join Entity
  {
    public int RentalServiceId { get; set; }
    public int VehicleId { get; set; }
    public Vehicle Vehicle { get; set; } // reference navigation property
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } // reference navigation property
    public string ServiceAgentId { get; set; }
    public ApplicationUser ServiceAgent { get; set; } // reference navigation property
    public DateTime ReservationStart { get; set; }
    public DateTime ReservationEnd { get; set; }
  }
}