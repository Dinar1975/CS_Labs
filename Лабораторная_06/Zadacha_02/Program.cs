using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // много похожих действий
            //Console.Write(17 + " ");
            //Console.Write(18 + " ");
            //Console.Write(19 + " ");
            //Console.Write(20 + " ");
            //Console.Write(21 + " ");

            // определили чем отличаются действия
            // заменили различия на переменную
            //int a;
            //a = 17;
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
            int a;
            a = 17;
            int b = 47;
            while(a <= b)
            {
                Console.Write(a + " ");
                a = a + 1;
            }
            


        }
    }
}
