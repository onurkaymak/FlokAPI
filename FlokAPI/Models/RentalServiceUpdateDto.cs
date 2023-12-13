namespace FlokAPI.Models;

public class RentalServiceUpdateDto
{
  public int RentalServiceId { get; set; }
  public int VehicleId { get; set; }
  public int CustomerId { get; set; }
  public string ServiceAgentId { get; set; }
  public string ReservationStart { get; set; }
  public string ReservationEnd { get; set; }
}