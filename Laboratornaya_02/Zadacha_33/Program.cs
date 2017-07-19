using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_33
{
    class Program
    {
        static void Main(string[] args)
        {
            string h;
            h = Console.ReadLine();
            double H;
            H = double.Parse(h);
            if (H < 0)
            {
                Console.WriteLine("Высота над уровнем Земли должна быть неотрицательной");
                return;
            }
            
            double c;
            c = H + 6350;
            double b;
            b = 6350;
            double a;
            a = Math.Sqrt(c * c - b * b);
            Console.WriteLine("{0:F4}", a);
                        
        }
    }
}
