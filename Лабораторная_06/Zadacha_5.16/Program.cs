using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._16
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);

            

            while (A <= 20)
            {
                Console.WriteLine("{0:F4}", Math.Sin(A));
                A = A + 1;
            }

        }
    }
}
