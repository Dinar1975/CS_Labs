using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_23
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
            R = B * B - 4 * A * C;
            Console.WriteLine("{0:F4}", R);
            
        }
    }
}
