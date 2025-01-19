using Xunit;

namespace AidnNews.Tests.Domains.NewsCalculator.Entities
{
  public class BodyTempTests
  {
    [Fact]
    public void BodyTemp_Score_LowerLimit()
    {
      // Arrange
      var BodyTemp = new BodyTemp(35);

      // Act
      var score = BodyTemp.Score;

      // Assert
      Assert.Equal(3, score);
    }

    [Fact]
    public void BodyTemp_Score_Is_1_LowerLimit()
    {
      // Arrange
      var BodyTemp = new BodyTemp(36);

      // Act
      var score = BodyTemp.Score;

      // Assert
      Assert.Equal(1, score);
    }


    [Fact]
    public void BodyTemp_Score_Is_0_LowerLimit()
    {
      // Arrange
      var BodyTemp = new BodyTemp(37);

      // Act
      var score = BodyTemp.Score;

      // Assert
      Assert.Equal(0, score);
    }

    [Fact]
    public void BodyTemp_Score_Is_0_UpperLimit()
    {
      // Arrange
      var BodyTemp = new BodyTemp(38);

      // Act
      var score = BodyTemp.Score;

      // Assert
      Assert.Equal(0, score);
    }

    [Fact]
    public void BodyTemp_Score_Is_1_LowerLimit_HigherValues()
    {
      // Arrange
      var BodyTemp = new BodyTemp(39);

      // Act
      var score = BodyTemp.Score;

      // Assert
      Assert.Equal(1, score);
    }

    [Fact]
    public void BodyTemp_Score_Is_2_LowerLimit_HigherValues()
    {
      // Arrange
      var BodyTemp = new BodyTemp(40);

      // Act
      var score = BodyTemp.Score;

      // Assert
      Assert.Equal(2, score);
    }

    [Fact]
    public void BodyTemp_Score_Is_2_UpperLimit_HigherValues()
    {
      // Arrange
      var BodyTemp = new BodyTemp(42);

      // Act
      var score = BodyTemp.Score;

      // Assert
      Assert.Equal(2, score);
    }

    [Fact]
    public void BodyTemp_Throws_Error_LowerThreshold()
    {
      // Arrange
      var BodyTempValue = 31;

      // Act & Assert
      Assert.Throws<ArgumentOutOfRangeException>(() => new BodyTemp(BodyTempValue));
    }

    [Fact]
    public void BodyTemp_Throws_Error_UpperThreshold()
    {
      // Arrange
      var BodyTempValue = 43;

      // Act & Assert
      Assert.Throws<ArgumentOutOfRangeException>(() => new BodyTemp(BodyTempValue));
    }
  }
}
