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
            int a;
            a = 1;

            int b;
            b = 7;

            int c;
            c = 7;

            int n;
            n = 9;
            
            while (a <= 9)
            {
                Console.WriteLine(a + " " + "x" + " " + b + " " + "=" + " " + c);
                a = a + 1;
                c = c + 7;
            }
        }
    }
}
