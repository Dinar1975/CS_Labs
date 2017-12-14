using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 100;    // а меняется от 100 до 500 с шагом 1 
                        // сумма меняется c шагом а от значения а=100 до значения с=500 
            int c;
            c = 500;    // постоянная 500

            int sum;
            sum = 0;

            Console.Write("Ход решения:");
            while (a <= c)
            {
                sum = sum + a;
                Console.Write(sum + " "); 
                a = a + 1;                
            }

            Console.WriteLine("Ответ:" + sum);
          

        }
    }
}
