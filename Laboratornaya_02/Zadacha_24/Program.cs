using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            y = Console.ReadLine();
            double Y;
            Y = double.Parse(y);
            string m1;
            m1 = Console.ReadLine();
            double M1;
            M1 = double.Parse(m1);
            string m2;
            m2 = Console.ReadLine();
            double M2;
            M2 = double.Parse(m2);
            string r;
            r = Console.ReadLine();
            double R;
            R = double.Parse(r);
            if (R == 0)
            {
                Console.WriteLine("Значение R должно быть не равно нулю");
                return;
            }

            double C;
            C = Y * M1 * M2 / R / R;
            Console.WriteLine("{0:F4}", C);
            
        }
    }
}
