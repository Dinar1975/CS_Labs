using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            n = Console.ReadLine();
            int N;
            N = int.Parse(n);

            if (N <= 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
                return;
            }

            int i = 0;
            int m = 1;
                        
            while (i < N)
            {
                Console.Write("#");
                

                if (m == 20)
                {
                    Console.WriteLine(" ");
                    m = 0;
                }

                i = i + 1;
                m = m + 1;

            }






        }
    }
}
