using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = 1;

            Console.WriteLine("Введите число");

            string n;
            n = Console.ReadLine();
            double N;
            N = double.Parse(n);

            if (N <= 0)
            {
                Console.WriteLine("Значение N должно быть положительным");
                return;
            }

            double sum;
            sum = 0;
            //Console.WriteLine(sum);
            //sum = sum + 1.0 / 2;
            //Console.WriteLine(sum);
            //sum = sum + 1.0 / 3;
            //Console.WriteLine(sum);
            //sum = sum + 1.0 / 4;
            //Console.WriteLine(sum);


            

            while (a <= N)
            {
                sum = sum + 1.0 / a;
                a = a + 1.0;
            }

            Console.WriteLine("Ответ:" + sum);






        }
    }
}
