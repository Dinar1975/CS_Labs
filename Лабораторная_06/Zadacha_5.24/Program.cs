using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 + "," + 2);

            int a;
            a = 2;

            int b;
            b = 9;

            while (a <= b)
            {
                Console.WriteLine(3 + "," + a);
                a = a + 1;
            }
        }
    }
}
