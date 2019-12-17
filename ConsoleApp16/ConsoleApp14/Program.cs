using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            first:
            Console.WriteLine("Введите пароль:");
            string x = Console.ReadLine();
            if (x != "root")
            {
                Console.WriteLine("Неверный пароль!");
                goto first;
            } else
            {
                Console.WriteLine("Правильный пароль!");
            }
             
        }
    }
}
