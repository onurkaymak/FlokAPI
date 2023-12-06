namespace FlokAPI.Models
{
  public class Vehicle
  {
    public int VehicleId { get; set; }
    public int VIN { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public string Class { get; set; }
    public string ClassCode { get; set; }
    public int Mileage { get; set; } = 0;
    public bool IsRented { get; set; } = false;
    public bool InProduction { get; set; } = false;
  }
}