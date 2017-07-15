using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_25
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);
            string b;
            b = Console.ReadLine();
            double B;
            B = double.Parse(b);
            string c;
            c = Console.ReadLine();
            double C;
            C = double.Parse(c);
            double R;
            R = Math.Sqrt(A * A + B * B - 2 * A * B * Math.Cos(C * Math.PI / 180));
            Console.WriteLine("{0:F4}", R);

        }
    }
}
