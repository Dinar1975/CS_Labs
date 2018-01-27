using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 1;

            double b;
            b = 2.54;

            int n;
            n = 22;

            while (a <= n)
            {
                Console.WriteLine(a + " " + b);
                a = a + 1;
                b = b + 2.54;
            }
                                    
        }
    }
}
