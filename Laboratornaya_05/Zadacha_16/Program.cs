using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);
            string y;
            y = Console.ReadLine();
            double Y;
            Y = double.Parse(y);
            string z;
            z = Console.ReadLine();
            double Z;
            Z = double.Parse(z);
            
            if ((X > Y) && (X > Z))
                Console.WriteLine("{0}", X);

            if ((Y > X) && (Y > Z))
                Console.WriteLine("{0}", Y);

            if ((Z > X) && (Z > Y))
                Console.WriteLine("{0}", Z);
            
        }
    }
}
