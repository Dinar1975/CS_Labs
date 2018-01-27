using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._6._2
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

            while ((A <= 24) && (B <= 23))
            {
                Console.WriteLine(A + " " + B + "." + "5" + " " + A + "." + "8");
                A = A + 1;
                B = B + 1;
            }


        }
    }
}
