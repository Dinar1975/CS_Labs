using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Группа повторяющихся действий:
            //Console.WriteLine(1 * 1 * 1 + " ");
            //Console.WriteLine(2 * 2 * 2 + " ");
            //Console.WriteLine(3 * 3 * 3 + " ");
            //Console.WriteLine(4 * 4 * 4 + " ");
            //Console.WriteLine(5 * 5 * 5 + " ");

            //Определили чем отличаются действия 
            //Заменили отличия на переменную

            Console.WriteLine("Введите число <= 50");

            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);

            int b;
            b = 50;

            while (A <= 50)
            {
                Console.WriteLine(A * A * A + " ");
                A = A + 1;

            }

            
        }
    }
}
