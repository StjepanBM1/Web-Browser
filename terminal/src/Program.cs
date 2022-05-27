using System;

namespace exerci
{
    public struct Args
    {
        public bool args;
        public string website;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Args arg = new Args();

            Console.WriteLine("Exerci 0.0.3 - Terminal version | © 2022 ringwormGO");
            
            if (args.Length == 0)
            {
                arg.args = false;
            }

            else
            {
                arg.website = args[1];
            }

            Terminal.terminal();
        }
    }
}