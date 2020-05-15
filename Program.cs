using System;
using System.IO;
using NixSouls.Logging;

// this program is supposed to take frequent backups of your game file while
// you are playing. right now though it just makes a backup when you run
// the program, and it overrides the old save if you have one, kind of shit
// xdddddxd ;)
// and that's assuming the save folder is the same as on my system which is
// highly unlikely, so you have to change GAME_PATH as well.

// heads-up: this only works if you're using the steam proton version of DSIII.

namespace NixSouls
{
    public class Program
    {
        private static ILogger _logger = LogManager.GetForClass();

        // I bet the last folder (01100001028087fa) is system-specific and is
        // gonna fuck me over for now, just change it if you need to for now...
        private const string GAME_PATH = "/.steam/steam/steamapps/compatdata/374320/pfx/drive_c/users/steamuser/Application Data/DarkSoulsIII/01100001028087fa/";
        private const string SAVE_FILE = "DS30000.sl2";
        private const string BACKUP_PATH = "backup";

        static void Main(string[] args)
        {
            var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var dir = $"{home}{GAME_PATH}";
            var path = $"{dir}{SAVE_FILE}";

            if (!File.Exists(path))
            {
                _logger.Log(LogLevel.Fatal, $"could not find savefile at: {path}");
                Console.ReadLine();
                Environment.Exit(-1);
            }

            _logger.Log($"original savefile location: {path}");

            if (!Directory.Exists($"{dir}{BACKUP_PATH}"))
            {
                _logger.Log($"creating backup directory ({dir}{BACKUP_PATH})...");
                Directory.CreateDirectory($"{dir}{BACKUP_PATH}");
            }

            // test backup
            _logger.Log($"saving to: {dir}{BACKUP_PATH}/sav.bak");
            File.Copy(path, $"{dir}{BACKUP_PATH}/sav.bak");
        }
    }
}
