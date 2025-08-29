public class HybridLogger : ILogger
{
  public void Log(string message)
  {
    Console.WriteLine(message);
    File.WriteAllText("hybrid-log.txt", message);
  }
}