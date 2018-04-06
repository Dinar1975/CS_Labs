using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._18
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);

            int t;
            t = 4*A;

            double z;
            z = 3.5 * t * t - 7 * t + 16;

            Console.WriteLine("{0:F4}", z);

        }
    }
}
