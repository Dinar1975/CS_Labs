using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            double Y;
            Y = double.Parse(t);
            double R;
            R = 5 * Math.Cos(Y*Math.PI/180);  // значение угла переводим в радианы
            Console.WriteLine("{0:F4}", R);
            

        }
    }
}
