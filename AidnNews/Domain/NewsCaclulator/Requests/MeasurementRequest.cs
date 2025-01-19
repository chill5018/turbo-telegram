namespace AidnNews.Models
{
  public class MeasurementDto
  {
    public required string Type { get; set; }
    public decimal Value { get; set; }
  }

  public class MeasurementRequest
  {
    public List<MeasurementDto> Measurements { get; set; } = new();
  }
}
