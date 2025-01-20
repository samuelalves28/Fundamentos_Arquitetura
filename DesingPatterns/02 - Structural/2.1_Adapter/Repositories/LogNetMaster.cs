using DesingPatterns._02___Structural._2._1_Adapter.Interfaces;

namespace DesingPatterns._02___Structural._2._1_Adapter.Repositories;

public class LogNetMaster : ILogNetMaster
{
    public void LogInfo(string message)
    {
        Console.WriteLine("Log Customizado - " + message);
    }

    public void LogException(Exception exception)
    {
        Console.WriteLine("Log Customizado - " + exception.Message);
    }
}
