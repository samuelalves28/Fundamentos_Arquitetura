using DesingPatterns._02___Structural._2._1_Adapter.Interfaces;

namespace DesingPatterns._02___Structural._2._1_Adapter.Repositories;

public class Logger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Log padrão - " + message);
    }

    public void LogErro(Exception exception)
    {
        Console.WriteLine("Log padrão - " + exception.Message);
    }
}
