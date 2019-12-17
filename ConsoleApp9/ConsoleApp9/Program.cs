using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите валюту (грн/дол/евро): ");
            string val = Console.ReadLine();
            double x;
            double y;
            if (val == "грн")
            {
                x = sum / 23.25;
                y = sum / 25.8;
                Console.WriteLine($"{sum} грн = {Math.Round(x,2)} долларов или {Math.Round(y, 2)} евро");
            }
            if (val == "дол")
            {
                x = sum * 23.25;
                y = sum * 0.88;
                Console.WriteLine($"{sum} дол = {Math.Round(x, 2)} грн или {Math.Round(y, 2)} евро");
            }
            if (val == "евро")
            {
                x = sum * 25.8;
                y = sum * 1.1;
                Console.WriteLine($"{sum} евро = {Math.Round(x, 2)} грн или {Math.Round(y, 2)} доллара");
            }
        }
    }
}
