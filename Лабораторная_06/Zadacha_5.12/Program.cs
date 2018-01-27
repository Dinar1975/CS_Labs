using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int h;
            h = 100;

            double p0;
            p0 = 1.29;

            double z;
            z = -0.000125;

            int n;
            n = 1000;
            
            while (h <= n)            
                
            {
                Console.WriteLine(h + " " + "{0:F4}", p0 * Math.Exp(-h * z));
                h = h + 100;
             
            }

            
        }
    }
}
