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
            string x;
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);

            if ((X > -3) && (X < 5))
            {
                Console.WriteLine(X);
            }
                                             
            string y;
            y = Console.ReadLine();
            double Y;
            Y = double.Parse(y);
            
            if ((Y > -3) && (Y < 5))
            {
                Console.WriteLine(Y);
            }
            
            string z;
            z = Console.ReadLine();
            double Z;
            Z = double.Parse(z);

            if ((Z > -3) && (Z < 5))
            {
                Console.WriteLine(Z);
            }

                    
        }
    }
}
