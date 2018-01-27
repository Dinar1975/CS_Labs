using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Группа повторяющихся действий:
            //Console.WriteLine(20 + " ");
            //Console.WriteLine(21 + " ");
            //Console.WriteLine(22 + " ");
            //Console.WriteLine(23 + " ");
            //Console.WriteLine(24 + " ");
            //Console.WriteLine(25 + " ");
            //Console.WriteLine(26 + " ");
            //Console.WriteLine(27 + " ");
            //Console.WriteLine(28 + " ");
            //Console.WriteLine(29 + " ");
            //Console.WriteLine(30 + " ");
            //Console.WriteLine(31 + " ");
            //Console.WriteLine(32 + " ");
            //Console.WriteLine(33 + " ");
            //Console.WriteLine(34 + " ");
            //Console.WriteLine(35 + " ");

            // Определили чем отличаются действия 
            // Заменили различия на переменную

            int a;
            a = 20;

            int b;
            b = 35;

            while(a <= b)
            {
                Console.WriteLine(a + " ");
                a = a + 1;
            }




        }

    }
}
