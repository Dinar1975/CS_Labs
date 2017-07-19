using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_35
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1;
            x1 = Console.ReadLine();
            double X1;
            X1 = double.Parse(x1);
            string x2;
            x2 = Console.ReadLine();
            double X2;
            X2 = double.Parse(x2);
            double R;
            R = Math.Sqrt(X2 * X2 + X1 * X1);
            Console.Write("{0:F4}", R);

        }
    }
}
