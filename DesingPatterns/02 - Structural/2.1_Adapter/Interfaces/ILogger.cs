namespace DesingPatterns._02___Structural._2._1_Adapter.Interfaces;

public interface ILogger
{
    void Log(string message);
    void LogErro(Exception exception);
}
