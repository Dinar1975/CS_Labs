using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            x = Console.ReadLine();
            int X;
            X = int.Parse(x);

            string y;
            y = Console.ReadLine();
            double Y;
            Y = double.Parse(y);

            if ((X < -2) && (Y > 1) || (X == -2) & (Y == 1))
            {
                Console.WriteLine("Точка с координатами {0}, {1} принадлежит множеству", X, Y);
            }
            
            else
            {
                Console.WriteLine("Точка с координатами {0}, {1} не принадлежит множеству", X, Y);
            }
        }
    }
}
