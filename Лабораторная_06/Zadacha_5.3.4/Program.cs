using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Группа повторяющихся действий:

            //Console.WriteLine(1 + " ");
            //Console.WriteLine(2 + " ");
            //Console.WriteLine(3 + " ");
            //Console.WriteLine(4 + " ");
            //Console.WriteLine(5 + " ");

            //Определили чем отличаются действия:
            //Заменили отличия на переменную:


            Console.WriteLine("Введите число A");

            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);

            Console.WriteLine("Введите число B");

            string b;
            b = Console.ReadLine();
            int B;
            B = int.Parse(b);

            while (A <= B)
            {
                Console.WriteLine(A + " ");
                A = A + 1;
            }







        }
    }
}
