using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Группа повторяющихся действий:

            //Console.WriteLine(10 10.4 + " ");
            //Console.WriteLine(11 11.4 + " ");
            //Console.WriteLine(12 12.4 + " ");
            //Console.WriteLine(13 13.4 + " ");
            //Console.WriteLine(14 14.4 + " ");
            //Console.WriteLine(15 15.4 + " ");

            //Определили чем отличаются действия:
            //заменили отличия на переменную:


            Console.WriteLine("Введите A");

            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);


            int b;
            b = 25;

            while (A <= b)
            {
                Console.WriteLine(A + " " + A + "." + "4" + " " );
                A = A + 1;
            }





        }
    }
}
