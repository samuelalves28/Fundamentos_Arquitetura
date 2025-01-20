
namespace DesingPatterns._02___Structural._2._1_Adapter
{
    public interface ILogAdapter
    {
        void Log(string message);
        void LogErro(Exception exception);
    }
}