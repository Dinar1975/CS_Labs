using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string r;
            r = Console.ReadLine();
            double R;
            R = double.Parse(r);

            if (R < 0)
            {
                Console.WriteLine("Радиус должен быть положительным");
                return;
            }
            
            double T;
            T = Math.PI * R * R;                     // Площадь круга
            
            string e;
            e = Console.ReadLine();
            double E;
            E = double.Parse(e);

            if (E < 0)
            {
                Console.WriteLine("Сторона квадрата должна быть положительна");
                return;
            }
            
            double SK;
            SK = E * E;                           // Площадь квадрата
            
            if (SK > T)
            {
                Console.WriteLine("Площадь квадрата {0:F4} больше площади круга {1:F4}", SK, T);
            }

            else
        
                if (T > SK)
            {
                Console.WriteLine("Площадь круга {1:F4} больше площади квадрата {0:F4}", T, SK);
            }
            


        }
    }
}
