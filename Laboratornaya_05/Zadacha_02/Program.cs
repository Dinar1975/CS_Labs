using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string p;
            p = Console.ReadLine();
            double P;
            P = double.Parse(p);
            string q;
            q = Console.ReadLine();
            double Q;
            Q = double.Parse(q);
            if (P < Q)
            {
                Console.WriteLine("Минимальное {0}; максимальное {1}", P, Q);
            }
            else
            {
                Console.WriteLine("Максимальное {0}; минимальное {1}", P, Q);
            }


        }
    }
}
