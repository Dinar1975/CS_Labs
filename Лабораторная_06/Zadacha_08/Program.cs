using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 1;

            int n;
            n = 20;

            int b;
            b = 453;

            while (a <= n)
            {
                Console.WriteLine(a + " " + b);
                a = a + 1;
                b = b + 453;
            }

        }
    }
}
