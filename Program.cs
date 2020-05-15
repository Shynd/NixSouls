using System;
using NixSouls.Logging;


namespace NixSouls
{
    public class Program
    {
        private static ILogger _logger = LogManager.GetForClass();

        // I bet this the last folder is system-specific and is gonna fuck me over, just change it if you need to for now...
        private const string GAME_PATH = "/.steam/steam/steamapps/compatdata/374320/pfx/drive_c/users/steamuser/Application Data/DarkSoulsIII/01100001028087fa/";
        private const string SAVE_FILE = "DS30000.sl2";

        static void Main(string[] args)
        {
            var home = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Console.WriteLine($"{home}{GAME_PATH}");
            _logger.Log("xd");
        }
    }
}
