using AidnNews.Application.Services;
using AidnNews.Models;

namespace AidnNews.Services
{
  public class NewsCalculatorService: INewsCalculatorService
  {
    public int CalculateNewsScore(MeasurementRequest request)
    {
      int totalScore = 0;
      foreach (var measurement in request.Measurements)
      {
        totalScore += GetScoreOfMeasurement(measurement.Type, measurement.Value);
      }
      return totalScore;
    }

    private int GetScoreOfMeasurement(string type, decimal value) {
        return type.ToUpper() switch {
        "TEMP" => new BodyTemp(value).Score,
        "HR" => new HeartRate(value).Score,
        "RR" => new RespiratoryRate(value).Score,
        _ => throw new ArgumentException($"Unknown measurement type: {type}")
      };
    }
  }
}
