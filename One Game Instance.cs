using System;
using System.IO;

namespace GameInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Custom error message.
            const string ERROR = "Instance already running.";
            // Custom file name, I'd recommend leaving the Environment.SpecialFolder.ApplicationData
            string TOKEN_FILE = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "game_name.token");

            try
            {
                if (File.Exists(TOKEN_FILE))
                {
                    try
                    {
                        File.Delete(TOKEN_FILE);
                    }
                    catch (IOException)
                    {
                        if (!Debugger.IsAttached)
                        {
                            Console.WriteLine(ERROR);
                            Environment.Exit(0);
                        }
                    }
                }
                using (StreamWriter token = File.CreateText(TOKEN_FILE))
                {
                    // Do something with the token file
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
//  ruby

One Game Instance
#-------------------------------------------------------------------------------
# Intro:
# Prevents players from opening multiple instances of your games.
#
# Features:
# Prevents Multiple Instances
# Custom File/Error
# XP/VX Compatible
#
# Instructions:
# Place as first script.
# Configure the 2 variables and thats all!
#
# Compatibility:
# Works with everything.
#
# Credits:
# game_guy ~ For creating it.
# ZenVirZan ~ For requesting it.
#===============================================================================

# Custom error message.
ERROR = "Instance already running."
# Custom file name, I'd recommend leaving the ENV[Appdata]
TOKEN_FILE = ENV['APPDATA'] + "game_name.token"

begin
  if FileTest.exists?(TOKEN_FILE)
    begin
      File.delete(TOKEN_FILE)
    rescue Errno::EACCES
      if $DEBUG == false || $DEBUG == nil || $TEST == false || $TEST == nil
        print ERROR
        exit
      end
    end
  end
  $token = File.open(TOKEN_FILE, "w")
end