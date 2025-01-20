using DesingPatterns._02___Structural._2._1_Adapter.Interfaces;

namespace DesingPatterns._02___Structural._2._1_Adapter;

public class LogAdapter(ILogNetMaster logNetMaster) : ILogger
{
    public void Log(string message)
    {
        logNetMaster.LogInfo(message);
    }

    public void LogErro(Exception exception)
    {
        logNetMaster.LogException(exception);
    }
}
