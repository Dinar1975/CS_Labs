using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_18
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
            string x3;
            x3 = Console.ReadLine();
            double X3;
            X3 = double.Parse(x3);
            double R;
            R = (X1 * X2) + (X1 * X3) + (X2 * X3);
            Console.WriteLine("{0}", R);
            
        }
    }
}
