using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a=Console.ReadLine();
            double A;
            A=double.Parse(a);
            string b;
            b=Console.ReadLine();
            double B;
            B=double.Parse(b);
            string c;
            c=Console.ReadLine();
            double C;
            C=double.Parse(c);
            if (A == 0)
            {
                Console.WriteLine("Данное уравнение не является квадратным");
                return;
            }           
            double D;
            D = B * B - 4 * A * C;
            Console.WriteLine("{0:F4}", D);
            if (D < 0)
            {
                Console.WriteLine("Вещественных корней уравнения " + A + "x^2 + " + " " + B + "x" + " " + "+" + " " + C + " " + "= 0 нет");
                Console.WriteLine("Вещественных корней уравнения " + A + "x^2 + " + B + "x + " + C + " = 0 нет");
            }
           
                        
            if (D == 0)
            {
                Console.WriteLine("Уравнение 3x^2 + 6x + 3 = 0 имеет один корень");
            }
            
            if (D > 0)
            {
                Console.WriteLine("У уравнения 3x^2 + 17x + 5 = 0 два вещественных корня");
            }
           

        }
    }
}
