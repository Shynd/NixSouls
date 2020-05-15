namespace NixSouls.Logging
{
    public interface ILogger
    {
        void Log(string msg);
        void Log(LogLevel level, string msg);
    }
}