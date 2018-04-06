using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._25
{
    class Program
    {
        static void Main(string[] args)
        {
            // много похожих действий
            //Console.Write(2 + "," + 2);
            //Console.Write(2 + "," + 4);
            //Console.Write(2 + "," + 6);
            //Console.Write(2 + "," + 8);
            //Console.Write(3 + "," + 0);
            //Console.Write(3 + "," + 2);
            //Console.Write(3 + "," + 4);



            // определили чем отличаются действия
            // заменили различия на переменную
            //int a;
            //a = 2;
            //Console.Write(a + " ");
            //a = a + 1;
            //Console.Write(a + " ");
            //a = a + 1;
            //Console.Write(a + " ");
            //a = a + 1;
            //Console.Write(a + " ");
            //a = a + 1;
            //Console.Write(a + " ");

            // выделили группу повторяющихся действий 
            // оформили цикл

            Console.WriteLine("Вывести первый вариант задачи");
            int m;
            m = 20;

            int p;            
            int q;

            p = m % 10;
            q = m / 10;

            //Console.WriteLine(q + "," + p);
            //m = m + 2;
            //p = m % 10;
            //q = m / 10;

            //Console.WriteLine(q + "," + p);
            //m = m + 2;
            //p = m % 10;
            //q = m / 10;
            //Console.WriteLine(q + "," + p);
            //m = m + 2;
            //p = m % 10;
            //q = m / 10;

            while (m <= 42)
            {
                Console.WriteLine(q + "," + p);
                m = m + 2;
                p = m % 10;
                q = m / 10;

            }


            //while (p <= 4)
            //{

            //    while (q <= 8)
            //    {
            //        Console.WriteLine(q + "," + p);
            //        m = m + 2;
            //    }
            //}

            
            Console.WriteLine("Вывести второй вариант задачи");
            int j;
            j = 2;

            int i;
            i = 0;
                                
            while (j <= 4)
            {
                i = 0;

                while (i <= 8)
                {
                    Console.WriteLine(j + "," + i);
                    i = i + 2;                    
                }

                j = j + 1;
                
                
            }
            
        }
    }
}
