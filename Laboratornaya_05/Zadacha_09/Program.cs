using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sc;                      // Площадь круга
            Sc = Console.ReadLine();
            double SC;
            SC = double.Parse(Sc);

            if (SC < 0)
            {
                Console.WriteLine("Площадь круга должна быть положительной");
                return;
            }

            string Ss;                      // Площадь квадрата
            Ss = Console.ReadLine();
            double SS;
            SS = double.Parse(Ss);

            if (SS < 0)
            {
                Console.WriteLine("Площадь квадрата должна быть положительной");
                return;
            }
            
            double A;                       // Сторона квадрата     
            A = Math.Sqrt(SS);            
            double D;
            D = 2 * Math.Sqrt(SC / Math.PI);

            if (D <= A)
            {
                Console.WriteLine("Круг поместится в квадрате");
                return;                                  
            }

            if (D > A)
            {
                Console.WriteLine("Круг не поместится в квадрат");
                return;
            }

        }
    }
}
