using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Ведите число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Таблица умножения на {b}");

            for (int i = 1; i<=20; i++)
            {
                Console.WriteLine($"{i}*{b}={b*i}");
            }
        }
    }
       
}
