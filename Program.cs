using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        public static double Fun1 (int x)
        {
            return (4 * Math.Pow(x, 2) + 1) / (x - 5);
        }
        public static double Fun2 (int x)
        {
            return (3 * Math.Pow(x, 2) - 2);
        }
        static void Main(string[] args)
        {
            //Задача 3. Вычисление значения функции
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            if (x < 5)
            {
                double y = Fun1(x);
            }
            else
            {
                double y = Fun2(x);
            }
            Console.ReadKey();
        }
    }
}
