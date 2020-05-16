using System.Linq;
using System.Runtime.CompilerServices;
using NixSouls.Logging.Loggers;

namespace NixSouls.Logging
{
    public static class LogManager
    {
        public static ILogger GetCurrentClassLogger([CallerFilePath] string className = "")
        {
            var cleanName = className.Split('/')
                .LastOrDefault()
                .Split('.')
                .FirstOrDefault()
                .ToLower();
            return new ConsoleLogger(cleanName);
        }
    }
}