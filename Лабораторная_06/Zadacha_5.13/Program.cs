using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            int b = 7;

            int c = 7;

            int n = 9;

            while (a <= n)
            {
                Console.WriteLine(a + " " + "x" + " " + b + " " + "=" + c);
                a = a + 1;
                c = c + 7;
            }


        }
    }
}
