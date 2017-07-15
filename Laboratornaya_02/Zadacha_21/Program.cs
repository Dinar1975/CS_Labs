using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string r1;
            r1 = Console.ReadLine();
            double R1;
            R1 = double.Parse(r1);
            string r2;
            r2 = Console.ReadLine();
            double R2;
            R2 = double.Parse(r2);

            if (R1 == 0)
            {
                Console.WriteLine("Значение R1 должно быть не равно нулю");
                return;
            }

            if (R2 == 0)
            {
                Console.WriteLine("Значение R2 должно быть не равно нулю");
                return;
            }

            double R;
            R = 1 / R1 + 1 / R2;
            Console.WriteLine("{0:F4}", R);
            
        }
    }
}
