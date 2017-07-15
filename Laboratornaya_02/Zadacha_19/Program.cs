using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string v0;
            v0 = Console.ReadLine();
            double V0;
            V0 = double.Parse(v0);
            string t;
            t = Console.ReadLine();
            double T;
            T = double.Parse(t);
            string a;
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);
            double R;
            R = V0 * T + A * T * T / 2;
            Console.WriteLine("{0:F1}", R);
            
        }
    }
}
