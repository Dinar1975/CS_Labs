using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);
            double D;
            D = X * X;

            if (X > 0)
            {
                Console.WriteLine("{0}", D);
            }
            else
            {
                Console.WriteLine(X);
            }
      
            string y;
            y = Console.ReadLine();
            double Y;
            Y = double.Parse(y);
            double E;
            E = Y * Y;

            if (Y > 0)
            {
                Console.WriteLine("{0}", E);
            }
            else
            {
                Console.WriteLine(Y);
            }
            
            string z;
            z = Console.ReadLine();
            double Z;
            Z = double.Parse(z);
            double F;
            F = Z * Z;

            if (Z > 0)
            {
                Console.WriteLine("{0}", F);
            }
            else
            {
                Console.WriteLine(Z);
            }


        }
    }
}
