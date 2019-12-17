using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ставку: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int value = rnd.Next(1, 12);

            if (value >= 1 && value <= 5)
            {
                Console.WriteLine("Вы проиграли!");
            }
            if (value >= 6 && value <= 8)
            {
                Console.WriteLine($"Вы выиграли {x}!");
            }
            if (value >= 9 && value <= 11)
            {
                Console.WriteLine($"Вы выиграли {x*2}!");
            }
            if (value == 12)
            {
                Console.WriteLine($"Вы выиграли {x*10}!");
            }
        }
    }
}
