using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А");

            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);

            Console.WriteLine("Введите B");

            string b;
            b = Console.ReadLine();
            int B;
            B = int.Parse(b);

            int c;
            c = 10;

            int d;
            d = 8;

            while ((A >= c) && (B >= d))
            {
                Console.WriteLine(A + " " + B + "." + "2" + " ");
                A = A - 1;
                B = B - 1;

            }







        }
    }
}
