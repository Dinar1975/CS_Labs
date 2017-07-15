using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_29
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);
            if (X < 1)
            {
                Console.WriteLine("Значение X должно быть не меньше 1");
                return;
            }
            double R;
            R = (Math.Sqrt(X + 1) + Math.Sqrt(X - 1)) / 2 / Math.Sqrt(X);
            Console.WriteLine("{0:F4}", R);
            }
    }
}
