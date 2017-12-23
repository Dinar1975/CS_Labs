using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 20;

            int B = 40;

            int sum = 0;

            int kub;
            
            
            
            Console.Write("Ход решения:");
            Console.Write(sum + " ");
                        
            //kub = A * A * A;
            //A = A + 1;
            //sum = sum + kub;
            //Console.Write("+" + kub + "=" + " ");
            //Console.Write(sum + " ");

            //kub = A * A * A;
            //A = A + 1;
            //sum = sum + kub;
            //Console.Write("+" + kub + "=" + " ");
            //Console.Write(sum + " ");

            //kub = A * A * A;
            //A = A + 1;
            //sum = sum + kub;
            //Console.Write("+" + kub + "=" + " ");
            //Console.Write(sum + " ");

            //kub = A * A * A;
            //A = A + 1;
            //sum = sum + kub;
            //Console.Write("+" + kub + "=" + " ");
            //Console.Write(sum + " ");

            while (A >= 20 && A <= 40)
            {
                kub = A * A * A;
                A = A + 1;
                sum = sum + kub;
                Console.Write("+" + kub + "=" + " ");
                Console.Write(sum + " ");
            }
                        
            Console.Write("Результат" + sum);
        }
    }
}
