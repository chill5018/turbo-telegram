using AidnNews.Application.UseCases;
using AidnNews.Domain.NewsCalculator.Response;
using AidnNews.Models;
using Microsoft.AspNetCore.Mvc;

namespace AidnNews.Controllers {
  [ApiController]
  [Route("api/v1/[controller]")]
  public class NewsController : ControllerBase {

    private readonly CalculateNewsUseCase _useCase;

        public NewsController(CalculateNewsUseCase useCase)
        {
            _useCase = useCase;
        }

    [HttpPost("calculate")]
    public IActionResult CalculateScore([FromBody] MeasurementRequest request) {
      // Error Handling
      if (request == null || request.Measurements == null || !request.Measurements.Any()) {
        return BadRequest(new { Error = "Invalid input data. The request field and measurements are required." });
      }

      // Get Score
      try {
        var score = _useCase.Execute(request);
        return Ok(new NewsScoreResponse( score ));

      } catch (Exception ex) {
        return BadRequest(new { Error = ex.Message });
      }
    }
  }
}
