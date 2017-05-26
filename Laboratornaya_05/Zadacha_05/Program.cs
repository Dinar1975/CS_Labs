using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string l;
            l = Console.ReadLine();
            double L;
            L = double.Parse(l);
            string p;
            p = Console.ReadLine();
            double P;
            P = double.Parse(p);
            if (L < 0)
            {
                Console.WriteLine("Значение L должно быть неотрицательным");
                return;            
            }
            if (P < 0)
            {
                Console.WriteLine("Значение P должно быть неотрицательным");
                return;
            }
               
            if (L * 1000 < P * 0.305)
            {
                Console.WriteLine("Расстояние в километрах меньше");
            }
            else
            {
                Console.WriteLine("Расстояние в футах меньше");
            }
         
        }
    }
}
