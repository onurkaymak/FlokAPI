namespace FlokAPI.Models;
public class RentalServiceDto
{
  public string VIN { get; set; }
  public string CustomerEmail { get; set; }
  public string ServiceAgentId { get; set; }
  public string ReservationStart { get; set; }
  public string ReservationEnd { get; set; }
}