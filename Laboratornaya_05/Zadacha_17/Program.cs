using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string m;
            m = Console.ReadLine();
            double M;
            M = double.Parse(m);
            string p;
            p = Console.ReadLine();
            double P;
            P = double.Parse(p);

            if (P == 0)
            {
                Console.WriteLine("Значение P должно быть не равно нулю");
                return;
            }
            
            if (M % P == 0)
            {
                Console.WriteLine("{0}", M / P);
            }

            else
            { 
                Console.WriteLine("M не делится нацело на P");
            }
                        

        }
    }
}
