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
                Console.WriteLine("Подкоренное выражение должно быть не отрицательным");
                return;
            }
            if (A == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            string b;
            b = Console.ReadLine();
            double B;
            B = double.Parse(b);
            if (B == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            string c;
            c = Console.ReadLine();
            double C;
            C = double.Parse(c);
            if (C == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            string x;
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);
            if (X == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            double R;
            R = 1 / (Math.Sqrt(A * X * X + B * X + C));
            Console.WriteLine("{0:F4}", R);
        }
    }
}
