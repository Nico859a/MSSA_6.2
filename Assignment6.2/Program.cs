using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Games = new Stack<string>();

            Games.Push("Call Of Duty");
            Games.Push("Skyrim");
            Games.Push("Counter Strike");
            Games.Push("Rainbow Six");
            Games.Push("Fallout");

            foreach (var item in Games)
            {
                Console.WriteLine(item);
            }

            Games.Pop();
            Console.WriteLine();
            Console.WriteLine("Remaining games after removal:");
            Console.WriteLine();

            foreach (var item in Games)
            {
                Console.WriteLine(item);
            }

            Games.Pop();
            Console.WriteLine();
            Console.WriteLine("Remaining games after removal:");
            Console.WriteLine();

            foreach (var item in Games)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
