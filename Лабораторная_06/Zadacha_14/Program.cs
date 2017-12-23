using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A");

            string a;
            a = Console.ReadLine();
            long A;
            A = long.Parse(a);

            Console.WriteLine("Введите B");

            string b;
            b = Console.ReadLine();
            long B;
            B = long.Parse(b);

            long proizv;
            proizv = 1;

            if (A <= B)
            {
                while (A <= B)
                {
                    proizv = proizv * A;
                    Console.WriteLine(proizv + " ");
                    A = A + 1;
                }
            }
            else
            {
                while (A >= B)
                {
                    proizv = proizv * A;
                    Console.WriteLine(proizv + " ");
                    A = A - 1;
                }

            }

            Console.WriteLine("Результат произведения:" + proizv);
            

        }

    }
}
