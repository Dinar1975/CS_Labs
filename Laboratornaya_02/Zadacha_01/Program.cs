using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            double x;
            x = double.Parse(t);
            double c;  // Переменная для результата
            c = x + 7; // Складываем значение x и число 7
            Console.WriteLine("{0:F4}", c);

        }
    }
}
