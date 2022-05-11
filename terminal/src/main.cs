using System;

namespace exerci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exerci 0.0.2 | © 2022 ringwormGO | Build 30422");

            if (args.Length < 1)
            {
                Selection(1);
            }

            else
            {
                switch (args[1])
                {
                    case "1":
                        GUIStart.StartGUI();
                        break;

                    case "2":
                        TerminalStart.StartTerminal();
                        break;

                    case "x":
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;

                    default:
                        Selection(2);
                        break;
                }
            }
        }

        public static void Selection(int type)
        {
            switch (type)
            {
                case 1:
                    Console.WriteLine("There is no passed arguments!");
                    break;
                    
                case 2:
                    Console.WriteLine("Wrong argument, switcing to selection mode...!");
                    break;

                default:
                    break;
            }

            string selection;

            Console.WriteLine("1 - GUI | 2 - terminal | x = exit");
            Console.Write("Enter selection: ");
            selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    GUIStart.StartGUI();
                    break;

                case "2":
                    TerminalStart.StartTerminal();
                    break;

                case "x":
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong argument!");
                    break;
            }
        }
    }
}