using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._5._2
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

            Console.WriteLine("Введите В");

            string b;
            b = Console.ReadLine();
            int B;
            B = int.Parse(b);

            int C;
            C = 25;

            int D;
            D = 24;

            while ((A >= C) && (B >= D))

            {
                Console.WriteLine(A + " " + B + "." + "5" + " " + B + "." + "2");
                A = A - 1;
                B = B - 1;

            }





        }
    }
}
