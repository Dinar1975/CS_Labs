using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string x;
            x = Console.ReadLine();
            int X;
            X = int.Parse(x);
            
            double t;
            t = X + 2;

            double y;
            y = 2 *t * t + 5.5 * t - 2;
                     
           Console.WriteLine("{0:F4}", y);
                
                   
        }
    }
}
