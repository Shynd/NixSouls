using System;
using NixSouls.Logging;

namespace NixSouls.Logging.Loggers
{
    public class ConsoleLogger : ILogger
    {
        private string ClassName { get; set; }

        public ConsoleLogger(string className)
        {
            ClassName = className;
        }

        public void Log(string msg)
            => Log(LogLevel.Normal, msg);

        public void Log(LogLevel level, string msg)
        {
            Console.WriteLine($"[{level.ToString().ToLower()}] - [{ClassName}]: {msg}");
        }
    }
}