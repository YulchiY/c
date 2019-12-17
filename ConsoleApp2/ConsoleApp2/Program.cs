using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            
            if (x == "мяу")
            {
                Console.WriteLine("Покорми кота");
            }
            if (x == "гав")
            {
                Console.WriteLine("Погуляй с собакой");
            }   
        }
    }
}
