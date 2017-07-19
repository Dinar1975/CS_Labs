using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);

            string b;
            b = Console.ReadLine();
            double B;
            B = double.Parse(b);
            
            string c;
            c = Console.ReadLine();
            double C;
            C = double.Parse(c);
            
            if (A < 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }
            
            if (B < 0)
            {
                Console.WriteLine("Значение B должно быть неотрицательным");
                return;
            }

            if (C < 0)
            {
                Console.WriteLine("Значение C должно быть неотрицательным");
                return;
            }
            

            if (A == B || B == C || A == C)
            {
                Console.WriteLine("Треугольник является равнобедренным.");                
            }            
            else
            {
                Console.WriteLine("Треугольник не является равнобедренным.");                
            }

            
        }
    }
}
