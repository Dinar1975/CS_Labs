using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);

            string b;
            b = Console.ReadLine();
            int B;
            B = int.Parse(b);

            int sum;
            sum = 0;

            Console.WriteLine("Ход решения:");

            if (A <= B)
            {
                while (A <= B)
                {
                    sum = sum + A;
                    Console.WriteLine(sum + " ");
                    A = A + 1;
                }
            }

            else
            {
                while (A >= B)
                {
                    sum = sum + B;
                    Console.WriteLine(sum + " ");
                    B = B + 1;
                }
            }

            Console.WriteLine("Ответ:" + sum);
        }
    }
}
