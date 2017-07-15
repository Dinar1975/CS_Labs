using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);
            double R;
            R = Math.Sqrt(1 - (Math.Sin(X * Math.PI / 180) * Math.Sin(X * Math.PI / 180)));
            Console.WriteLine("{0:F4}", R);
            
        }
    }
}
