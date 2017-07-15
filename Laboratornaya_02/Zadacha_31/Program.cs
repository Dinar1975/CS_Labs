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
            string x;
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);
            double Y;
            Y = (7 * X * X) - (3 * X) + 6;
            Console.WriteLine("{0:F4}", Y);
        }
    }
}
