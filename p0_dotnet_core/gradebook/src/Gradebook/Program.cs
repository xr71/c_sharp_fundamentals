using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string name = args[0];
                Console.WriteLine("Hello " + name + "!");
                Console.WriteLine($"Hello {name}!");
            }
            else
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
