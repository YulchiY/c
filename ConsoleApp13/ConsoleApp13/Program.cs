using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите через пробел 5 целых чисел одной строкой:");
            
            string line = System.Console.ReadLine();
            string[] str_int = line.Split(' ');
           
            int a = Convert.ToInt32(str_int[0]);
            int b = Convert.ToInt32(str_int[1]);
            int c = Convert.ToInt32(str_int[2]);
            int d = Convert.ToInt32(str_int[3]);
            int e = Convert.ToInt32(str_int[4]);

            int average = (a + b + c + d + e) / str_int.Length;

            Console.WriteLine($"Среднее арифметическое введенных чисел: {average}");
        }
    }
}

