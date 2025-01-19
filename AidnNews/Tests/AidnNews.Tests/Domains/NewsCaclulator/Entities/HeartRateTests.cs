using Xunit;

namespace AidnNews.Tests.Domains.NewsCalculator.Entities
{
  public class HeartRateTests
  {
    [Fact]
    public void HeartRate_Score_LowerLimit()
    {
      // Arrange
      var heartRate = new HeartRate(26);

      // Act
      var score = heartRate.Score;

      // Assert
      Assert.Equal(3, score);
    }

    [Fact]
    public void HeartRate_Score_Is_1_LowerLimit()
    {
      // Arrange
      var heartRate = new HeartRate(41);

      // Act
      var score = heartRate.Score;

      // Assert
      Assert.Equal(1, score);
    }

    [Fact]
    public void HeartRate_Score_Is_1_UpperLimit()
    {
      // Arrange
      var heartRate = new HeartRate(50);

      // Act
      var score = heartRate.Score;

      // Assert
      Assert.Equal(1, score);
    }

    [Fact]
    public void HeartRate_Score_Is_0_LowerLimit()
    {
      // Arrange
      var heartRate = new HeartRate(51);

      // Act
      var score = heartRate.Score;

      // Assert
      Assert.Equal(0, score);
    }

    [Fact]
    public void HeartRate_Score_Is_0_UpperLimit()
    {
      // Arrange
      var heartRate = new HeartRate(90);

      // Act
      var score = heartRate.Score;

      // Assert
      Assert.Equal(0, score);
    }

    [Fact]
    public void HeartRate_Score_Is_1_LowerLimit_HigherValues()
    {
      // Arrange
      var heartRate = new HeartRate(91);

      // Act
      var score = heartRate.Score;

      // Assert
      Assert.Equal(1, score);
    }

    [Fact]
    public void HeartRate_Score_Is_1_UpperLimit_HigherValues()
    {
      // Arrange
      var heartRate = new HeartRate(110);

      // Act
      var score = heartRate.Score;

      // Assert
      Assert.Equal(1, score);
    }

    [Fact]
    public void HeartRate_Score_Is_2_LowerLimit_HigherValues()
    {
      // Arrange
      var heartRate = new HeartRate(111);

      // Act
      var score = heartRate.Score;

      // Assert
      Assert.Equal(2, score);
    }

    [Fact]
    public void HeartRate_Score_Is_2_UpperLimit_HigherValues()
    {
      // Arrange
      var heartRate = new HeartRate(130);

      // Act
      var score = heartRate.Score;

      // Assert
      Assert.Equal(2, score);
    }

    [Fact]
    public void HeartRate_Score_Is_3_LowerLimit_HigherValues()
    {
      // Arrange
      var heartRate = new HeartRate(131);

      // Act
      var score = heartRate.Score;

      // Assert
      Assert.Equal(3, score);
    }

    [Fact]
    public void HeartRate_Score_Is_3_UpperLimit_HigherValues()
    {
      // Arrange
      var heartRate = new HeartRate(220);

      // Act
      var score = heartRate.Score;

      // Assert
      Assert.Equal(3, score);
    }

    [Fact]
    public void HeartRate_Throws_Error_LowerThreshold()
    {
      // Arrange
      var heartRateValue = 25;

      // Act & Assert
      Assert.Throws<ArgumentOutOfRangeException>(() => new HeartRate(heartRateValue));
    }

    [Fact]
    public void HeartRate_Throws_Error_UpperThreshold()
    {
      // Arrange
      var heartRateValue = 221;

      // Act & Assert
      Assert.Throws<ArgumentOutOfRangeException>(() => new HeartRate(heartRateValue));
    }
  }
}
