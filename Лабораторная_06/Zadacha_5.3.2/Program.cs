using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Группа повторяющихся действий:
            //Console.WriteLine(10 * 10 + " ");
            //Console.WriteLine(11 * 11 + " ");
            //Console.WriteLine(12 * 12 + " ");
            //Console.WriteLine(13 * 13 + " ");
            //Console.WriteLine(14 * 14 + " ");
            //Console.WriteLine(15 * 15 + " ");

            //Определили чем отличаются действия
            //Заменили отличия на переменную

            int a;
            a = 10;

            Console.WriteLine("Введите число >= 10");

            string b;
            b = Console.ReadLine();
            int B;
            B = int.Parse(b);

            while (a <= B)
            {
                Console.WriteLine(a*a + " ");
                a = a + 1;
            }

            
        }
    }
}
