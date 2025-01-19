namespace AidnNews.Domain.NewsCalculator.Response
{
  public class NewsScoreResponse
  {
    public int Score { get; set; }

    public NewsScoreResponse(int score)
    {
      Score = score;
    }
  }
}
