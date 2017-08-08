using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);
            double R;
            R = Math.Abs(A);
            Console.WriteLine("{0}", R);
        }
    }
}
