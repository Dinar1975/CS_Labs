using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_26
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);
            if (A == 0)
            {
                Console.WriteLine("Значение A должно быть не равно нулю");
                return;
            }
            string b;
            b = Console.ReadLine();
            double B;
            B = double.Parse(b);
            string c;
            c = Console.ReadLine();
            double C;
            C = double.Parse(c);
            string d;
            d = Console.ReadLine();
            double D;
            D = double.Parse(d);
            if (D == 0)
            {
                Console.WriteLine("Значение D должно быть не равно нулю");
                return;
            }
            double R;
            R = ((A * D) + (B * C)) / (A * D);
            Console.WriteLine("{0:F4}", R);     
            
        }
    }
}
