using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*У гусей и кроликов вместе 64 лапы. Сколько может быть кроликов и
гусей (указать все сочетания)?*/
            int goose;
            int rabbit;
            for (goose=0; goose<=64; goose++)
            {
                for (rabbit = 0; rabbit<=32; rabbit++)
                {
                   if(2 * goose + 4 * rabbit == 64)
                    {
                        Console.WriteLine($"{goose} гусей и {rabbit} кроликов");
                   }
                }
            }
             
        }
    }
}
