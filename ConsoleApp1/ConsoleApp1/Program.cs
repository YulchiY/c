using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second number");
            int y = Convert.ToInt32(Console.ReadLine());
            int max;

            if (x > y)
            {
              max = x;
            }
            else
            {
               max = y;
            }
            Console.WriteLine("The bigger number is {0}", max);

            Console.ReadLine();
        }
    }
}
