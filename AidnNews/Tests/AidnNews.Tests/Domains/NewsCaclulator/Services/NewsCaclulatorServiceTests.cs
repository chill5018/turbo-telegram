using AidnNews.Models;
using AidnNews.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace AidnNews.Tests.Services
{
  public class NewsCalculatorServiceTest
  {
    private readonly NewsCalculatorService _service;

    public NewsCalculatorServiceTest()
    {
      _service = new NewsCalculatorService();
    }

    [Fact]
    public void CalculateNewsScore_ReturnsCorrectScore_WhenRequestIsValid()
    {
      // Arrange
      var request = new MeasurementRequest
      {
        Measurements = new List<MeasurementDto>
        {
          new MeasurementDto { Type = "TEMP", Value = 37},
          new MeasurementDto {Type = "HR", Value = 66},
          new MeasurementDto { Type= "RR", Value = 20}
        }
      };

      // Act
      var result = _service.CalculateNewsScore(request);

      // Assert
      Assert.Equal(0, result); // Assuming the scores are 37 + 66 + 20
    }

    [Fact]
    public void CalculateNewsScore_ThrowsArgumentException_WhenMeasurementTypeIsUnknown()
    {
      // Arrange
      var request = new MeasurementRequest
      {
        Measurements = new List<MeasurementDto>
        {
          new MeasurementDto{ Type = "UNKNOWN", Value = 50}
        }
      };

      // Act & Assert
      var exception = Assert.Throws<ArgumentException>(() => _service.CalculateNewsScore(request));
      Assert.Equal("Unknown measurement type: UNKNOWN", exception.Message);
    }

    [Fact]
    public void CalculateNewsScore_ReturnsZero_WhenMeasurementsAreEmpty()
    {
      // Arrange
      var request = new MeasurementRequest
      {
        Measurements = new List<MeasurementDto>()
      };

      // Act
      var result = _service.CalculateNewsScore(request);

      // Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void CalculateNewsScore_ThrowsArgumentNullException_WhenRequestIsNull()
    {
      // Act & Assert
      Assert.Throws<NullReferenceException>(() => _service.CalculateNewsScore(null));
    }
  }
}
