using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 50;

            Console.WriteLine("Введите стоимость 1 кг сыра");

            string b;
            b = Console.ReadLine();
            double B;
            B = double.Parse(b);

            double c;
            c = 1.0;

            int n;
            n = 2;

            while (a <= 1000)
            {
                Console.WriteLine(a + " " + c);
                a = a + 50;
                c=B/20*n;
                n = n + 1;

            }

        }
    }
}
