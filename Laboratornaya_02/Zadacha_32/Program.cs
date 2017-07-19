using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_32
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);
            double B;
            B = (12 * A * A) + (7 * A) - 16;
            Console.WriteLine("{0:F4}", B);            
        }
    }
}
