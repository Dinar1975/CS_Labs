using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Группа повторяющихся действий:

            //Console.WriteLine(25 + 25 + "." + 5 + " " + 24 + "." + 8 + " ");
            //Console.WriteLine(26 + 26 + "." + 5 + " " + 25 + "." + 8 + " ");
            //Console.WriteLine(27 + 27 + "." + 5 + " " + 26 + "." + 8 + " ");
            //Console.WriteLine(28 + 28 + "." + 5 + " " + 27 + "." + 8 + " ");
            //Console.WriteLine(29 + 29 + "." + 5 + " " + 28 + "." + 8 + " ");
            //Console.WriteLine(30 + 30 + "." + 5 + " " + 29 + "." + 8 + " ");
            //Console.WriteLine(31 + 31 + "." + 5 + " " + 30 + "." + 8 + " ");

            //Определили чем отличаются действия:
            //Заменили отличия на переменную:

            Console.WriteLine("Введите А");

            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);

            Console.WriteLine("Введите В");

            string b;
            b = Console.ReadLine();
            int B;
            B = int.Parse(b);

            int C;
            C = 35;

            int D;
            D = 34;

            while ((A <= C) && (B <= D))
            {
                Console.WriteLine(A + " " + A + "." + "5" + " " + B + "." + "8" + " ");
                A = A + 1;
                B = B + 1;
            }
                        
        }
    }
}
