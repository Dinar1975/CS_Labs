using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Много похожих действий:

            //Console.WriteLine(1 + " " + 65);
            //Console.WriteLine(2 + " " + 130);
            //Console.WriteLine(3 + " " + 195);
            //Console.WriteLine(4 + " " + 260);
            //Console.WriteLine(5 + " " + 325);

            //Определили чем отличаются действия
            //Заменили отличия на переменную

            ////int a;
            ////a = 1;
            ////Console.WriteLine(a + " " + 65);
            //a = a + 1;
            ////Console.WriteLine(a + " " + 130);
            //a = a + 1;
            ////Console.WriteLine(a + " " + 195);
            //a = a + 1;



            int a;
            a = 1;

            Console.WriteLine("Введите стоимость 1-го доллара США");

            string b;
            b = Console.ReadLine();
            double B;
            B = int.Parse(b);

            int n;
            n = 20;

            double sum;
            sum = B;

            while (a <= n)
            {
                Console.WriteLine(a + " " + B);
                a = a + 1;
                B = B + sum;
                
            }

        }
    }
}
