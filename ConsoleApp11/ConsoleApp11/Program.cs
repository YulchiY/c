using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 146);
        first:
            Console.WriteLine("Ваш вариант загаданного числа:");
            int userNum = Convert.ToInt32(Console.ReadLine());

            if (userNum != num)
            {
                if (userNum > num)
                {
                    Console.WriteLine("меньше");
                    goto first;
                }
                if (userNum < num)
                {
                    Console.WriteLine("больше");
                    goto first;
                }
            }
            else
            {
                Console.WriteLine("Вы угадали!");
            }
        }
    }
}