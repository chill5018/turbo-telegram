
using AidnNews.Models;

namespace AidnNews.Application.Services
{
  public interface INewsCalculatorService
  {
      int CalculateNewsScore(MeasurementRequest request);
  }
}
