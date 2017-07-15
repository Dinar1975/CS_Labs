using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);
            string y;
            y = Console.ReadLine();
            double Y;
            Y = double.Parse(y);
            string z;
            z = Console.ReadLine();
            double Z;
            Z = double.Parse(z);
            if ((X == Y) || (Y == Z) || (X == Z))
            {
                Console.WriteLine("Среди чисел есть равные");
            }
            else
            {
                Console.WriteLine("Числа не равны друг другу");
            }
            
        }
    }
}
