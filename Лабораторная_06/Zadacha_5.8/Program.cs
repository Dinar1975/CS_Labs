using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 1;

            double b;
            b = 0.453;

            int n;
            n = 10;

            while (a <= n)
            {
                Console.WriteLine(a + " " + b);
                a = a + 1;
                b = b + 0.453;
            }
            

        }
    }
}
