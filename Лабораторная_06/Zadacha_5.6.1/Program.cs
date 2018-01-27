using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A");

            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);

            Console.WriteLine("Введите B");

            string b;
            b = Console.ReadLine();
            int B;
            B = int.Parse(b);

            while ((A <= 35) && (B <= 34))
            {
                Console.WriteLine(A + " " + B + "." + "4");
                A = A + 1;
                B = B + 1;
            }






        }
    }
}
