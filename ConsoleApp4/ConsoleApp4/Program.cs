using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string y;

            y = x == 1 ? "Хорошо" : "Плохо";
            Console.WriteLine(y);
            
        }
    }
}
