using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите число:");
            
            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);
            
            Console.WriteLine("Сколько раз прописать:");
            
            //Console.WriteLine("a");
            //Console.WriteLine("a");
            //Console.WriteLine("a");
            //Console.WriteLine("a");
            //Console.WriteLine("a");
            //Console.WriteLine("a");
            //Console.WriteLine("a");
            //Console.WriteLine("a");

            string n; // Сколько нужно раз вводить число
            n = Console.ReadLine();
            int N;
            N = int.Parse(n);

            int i; // Сколько уже ввели раз
            i = 0;

            while (i < N)
            {
                Console.Write(A);
                i = i + 1;
            }



        }
    }
}
