using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_28
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);

            if (A < 0)
            {
                Console.WriteLine("значение A должно быть неотрицательным");
            }

            string b;
            b = Console.ReadLine();
            double B;
            B = double.Parse(b);

            if (B < 0)
            {
                Console.WriteLine("значение B должно быть неотрицательным");
            }

            string c;
            c = Console.ReadLine();
            double C;
            C = double.Parse(c);

            if (C < 0)
            {
                Console.WriteLine("значение C должно быть неотрицательным");
            }

            string d;
            d = Console.ReadLine();
            double D;
            D = double.Parse(d);

            if (D < 0)
            {
                Console.WriteLine("значение D должно быть неотрицательным");
            }

            if ((A < C) && (B < D))
            {
                Console.WriteLine("размещение возможно");
            }

            else
            {
                Console.WriteLine("размещение не возможно");
            }
        }
    }
}
