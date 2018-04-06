using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._20
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);

            while (A <= 0.9)
            {
                Console.WriteLine("{0:F4}", Math.Sqrt(A));
                A = A + 0.1;
            }
        }
    }
}
