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
            Random rand = new Random();
            int average = 0;
            int[] mass = new int[5];

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(0, 100);
                Console.Write(mass[i] + "\t");
                
            }
            Console.WriteLine("\n");
            for (int i = 0; i < mass.Length; i++)
            {
                average += mass[i];
            }
            
            Console.WriteLine($"Среднее арифметическое: {average/mass.Length}");
        }
    }
    
}
