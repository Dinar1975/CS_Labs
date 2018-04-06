using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 100;

            Console.WriteLine("Введите стоимость 1 кг конфет");

            string b;
            b = Console.ReadLine();
            double B;
            B = double.Parse(b);

            double c;
            c = B/10;

            int n;
            n = 2;

            while (a <= 2000)
            {
                Console.WriteLine(a + " " + c);
                a = a + 100;
                c = B / 10  * n;
                n = n + 1;
            }










        }
    }
}
