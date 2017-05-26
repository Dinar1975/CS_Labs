using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            double x;
            x = double.Parse(t);
            double R;
            R = Math.Sin(x * Math.PI / 180);
            Console.WriteLine("{0:F4}", R);
            
        }
    }
}
