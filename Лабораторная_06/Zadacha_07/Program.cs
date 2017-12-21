using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_07
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

            if (A <= B)
            {
                while (A <= B)
                {
                    Console.Write(A + " ");
                    A = A + 1;
                }
            }

            else
            {
                while (A >= B )
                {
                    Console.Write(A + " ");
                    A = A - 1;
                }
            }
        }
    }
}
