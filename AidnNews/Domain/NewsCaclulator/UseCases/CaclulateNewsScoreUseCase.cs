
using AidnNews.Application.Services;
using AidnNews.Models;

namespace AidnNews.Application.UseCases
{
    public class CalculateNewsUseCase
    {
        private readonly INewsCalculatorService _calculatorService;

        public CalculateNewsUseCase(INewsCalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public int Execute(MeasurementRequest request)
        {
            return _calculatorService.CalculateNewsScore(request);
        }
    }
}
