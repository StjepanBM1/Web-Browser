using System;
using System.Threading;

namespace exerci
{
    public class HomeScreen
    {
        public static void Home()
        {
           /*Console.WriteLine(
            @"  _____                   _           _                      _             _" +  
            @" | ____|_  _____ _ __ ___(_)         | |_ ___ _ __ _ __ ___ (_)_ __   __ _| |" + 
            @" |  _| \ \/ / _ \ '__/ __| |  _____  | __/ _ \ '__| '_ ` _ \| | '_ \ / _` | |" + 
            @" | |___ >  <  __/ | | (__| | |_____| | ||  __/ |  | | | | | | | | | | (_| | |" + 
            @" |_____/_/\_\___|_|  \___|_|          \__\___|_|  |_| |_| |_|_|_| |_|\__,_|_|"
            );*/

            if (exit_input() == 'x')
            {
                Console.WriteLine("Exiting...");
                Environment.Exit(0);
            }
        }

        private static char exit_input()
        {
            Console.SetCursorPosition(Console.WindowWidth / 3, Console.WindowHeight / 3);
            Console.Write("Enter 'x' if you want exit: ");
            return Convert.ToChar(Console.ReadLine());
        }
    }
}