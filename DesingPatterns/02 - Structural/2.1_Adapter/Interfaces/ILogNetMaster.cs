namespace DesingPatterns._02___Structural._2._1_Adapter.Interfaces;

public interface ILogNetMaster
{
    void LogInfo(string message);
    void LogException(Exception exception);
}
