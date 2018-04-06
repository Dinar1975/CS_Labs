using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывести первый вариант решения задачи");

            int i = 0;
            int n = 13;

            while (i < n)
            {

                Console.Write("!");
                if (i % 5 == 4)
                {
                    Console.Write(" ");
                }

                i = i + 1;
            }

            Console.WriteLine("Вывести второй вариант решения задачи");

            i = 0;

            int m;
            m = 1;

            while (i < n)
            {
                Console.Write("!");

                if (m == 5)

                {
                    Console.Write(" ");
                    m = 0;

                }
                i = i + 1;
                m = m + 1;
            }


        }
    }
}
