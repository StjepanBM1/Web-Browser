using System;
using System.Threading;

namespace exerci
{
    public class Terminal
    {
        public static void terminal()
        {
            Args args = new Args();

            Console.WriteLine("Starting terminal part...");

            if (!args.args)
            {
                Console.WriteLine("No arguments passed!");

                Thread.Sleep(1000);
                Console.Clear();

                HomeScreen.Home();
            }

            else
            {
                /* download website */
            }
        }
    }
}