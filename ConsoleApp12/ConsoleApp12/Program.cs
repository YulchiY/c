using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
                
            while (i*i < n)
            {
                Console.WriteLine((i * i++).ToString());
            }
             
        }
    }
}
