using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_34
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
            double R;
            R = 3 * Math.Sin(2 * A * Math.PI / 180) * Math.Cos(3 * B * Math.PI / 180);
            Console.WriteLine("{0:F4}", R);
            
        }
    }
}
