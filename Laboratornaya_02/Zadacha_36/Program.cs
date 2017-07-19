using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_36
{
    class Program
    {
        static void Main(string[] args)
        {
            string xa;
            xa = Console.ReadLine();
            double XA;
            XA = double.Parse(xa);
            string ya;
            ya = Console.ReadLine();
            double YA;
            YA = double.Parse(ya);
            string xb;
            xb = Console.ReadLine();
            double XB;
            XB = double.Parse(xb);
            string yb;
            yb = Console.ReadLine();
            double YB;
            YB = double.Parse(yb);
            double R;
            R = Math.Sqrt((XB - XA) * (XB - XA) + (YB - YA) * (YB - YA));
            Console.WriteLine("{0:F4}", R);
        }
    }
}
