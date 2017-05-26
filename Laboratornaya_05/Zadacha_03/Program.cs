using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string k;
            k = Console.ReadLine();
            double K;
            K = double.Parse(k);
            if (K > 0)
            {
                double R;
                R = Math.Sqrt(K);
                Console.WriteLine("{0:F4}", R);
            }
            else
            {
                double Q;
                Q = K * K;
                Console.WriteLine("{0:F4}", Q);
            }
            

        }
    }
}
