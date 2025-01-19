using System;
using System.ComponentModel.DataAnnotations;

public class RespiratoryRate {
    [Range(4,60, ErrorMessage = "Respiratory Rate is not within a valid range: 4-60")]
  public decimal Rr { get; private set; }
  public int Score { get; private set; }

  public RespiratoryRate(decimal rr) {
    Rr = rr;
    Score = GetScore(rr);
  }

  private int GetScore(decimal rr) => rr switch {
    > 3 and <= 8 => 3,
    > 8 and <= 11 => 1,
    > 11 and <= 20 => 0,
    > 20 and <= 24 => 2,
    > 24 and <= 60 => 3,
    _ => throw new ArgumentOutOfRangeException(nameof(rr), "Respiratory Rate is not within a valid range: 4-60")
  };
}
