using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string m;
            m = Console.ReadLine();
            double M;
            M = double.Parse(m);
            string a;
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);
            double R;
            R=M * 9.8067 * Math.Cos(A * Math.PI / 180);
            Console.WriteLine("{0:F4}", R);


        }
    }
}
