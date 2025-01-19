using System;
using System.ComponentModel.DataAnnotations;

public class HeartRate {

  [Range(26, 220, ErrorMessage = "Heart Rate is not within a valid range: 26-220")]
  public decimal Hr { get; private set; }
  public int Score { get; private set; }

  public HeartRate(decimal hr) {
    Hr = hr;
    Score = GetScore(hr);
  }

  private int GetScore(decimal hr) => hr switch {
    > 25 and <= 40 => 3,
    > 40 and <= 50 => 1,
    > 50 and <= 90 => 0,
    > 90 and <= 110 => 1,
    > 110 and <= 130 => 2,
    > 130 and <= 220 => 3,
    _ => throw new ArgumentOutOfRangeException(nameof(hr), "Heart Rate is not within a valid range: 26-220")
  };
}
