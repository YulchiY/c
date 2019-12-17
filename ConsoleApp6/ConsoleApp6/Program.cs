using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество километров: ");
            int km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество минут простоя: ");
            int minuts = Convert.ToInt32(Console.ReadLine());
            int costKm;
            
            
            if (km <= 5)
            {
                costKm = 20; 
            } else
            {
                costKm = 20 + (km - 5) * 3;
            }
            int cost = costKm + minuts;
            Console.WriteLine($"Общая сумма поездки {cost}");
        }
        
    }
}
