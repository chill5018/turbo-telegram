using System.ComponentModel.DataAnnotations;

public class BodyTemp {

    [Range(32,42, ErrorMessage = "Body Temp is not within a valid range: 32-42")]
  public decimal Temp { get; private set; }
  public int Score { get; private set; }

  public BodyTemp(decimal temp) {
    Temp = temp;
    Score = GetScore(temp);
  }

  private int GetScore(decimal temp) => temp switch {
    > 31 and <= 35 => 3,
    > 35 and <= 36 => 1,
    > 36 and <= 38 => 0,
    > 38 and <= 39 => 1,
    > 39 and <= 42 => 2,
    _ => throw new ArgumentOutOfRangeException(nameof(temp), "Body Temp is not within a valid range: 32-42")
  };
}
