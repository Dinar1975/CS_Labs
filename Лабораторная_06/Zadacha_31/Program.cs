using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_31
{
    class Program
    {
        static void Main(string[] args)
        {
            string w;
            w = Console.ReadLine();
            int W;
            W = int.Parse(w);

            int a = 0;
            int i = 1;
            int n = 1;

            while (n <= 9)
            {
                i = 1;
                a = a + 1;
                while (i <= W)
                {
                    Console.Write(a);
                    i = i + 1;
                    
                }
                n = n + 1;
                Console.WriteLine();

            }                      


        }
    }
}
