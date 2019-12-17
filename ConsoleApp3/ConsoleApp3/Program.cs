using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] month =
           {
                "Если вы видите эту надпись, то что-то пошло не так",
                "Зима",
                "Зима",
                "Весна",
                "Весна",
                "Весна",
                "Лето",
                "Лето",
                "Лето",
                "Осень",
                "Осень",
                "Осень",
                "Зима"
           };
            string input;
            int number;
            while (true)
            {
                Console.Write("Введите номер месяца: ");
                input = Console.ReadLine();
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Это не число!");
                    continue;
                }
                if (number > 0 && number < 13)
                {
                    Console.WriteLine(month[number]);
                    continue;
                }
                if (number == 0) break;
                Console.WriteLine("На этой планете нет такого месяца!");
            }
          
            
           
        }
    }
}
