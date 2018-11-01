using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_07
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            data = Console.ReadLine();

            String[] arr = data.Split(' ');

            String t = arr[0];

            arr[3] = arr[2];
            int i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(" " + arr[i] + i);
                i = i + 1;
            }
            Console.WriteLine();

            arr[4] = arr[3];
            i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(" " + arr[i] + i);
                i = i + 1;
            }
            Console.WriteLine();

            arr[5] = arr[4];
            i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(" " + arr[i] + i);
                i = i + 1;
            }
            Console.WriteLine();

            t = arr[5];
            i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(" " + arr[i] + i);
                i = i + 1;
            }
            Console.WriteLine();

            arr[0] = t;
            i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(" " + arr[i] + i);
                i = i + 1;
            }
            Console.WriteLine();

            arr[1] = arr[0];
            i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(" " + arr[i] + i);
                i = i + 1;
            }
            Console.WriteLine();

            arr[2] = arr[1];
            i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(" " + arr[i] + i);
                i = i + 1;
            }
            Console.WriteLine();

                        
            
            
            //arr[1] = arr[0];           // Гипотеза 2  
            //i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();

            //arr[2] = arr[1];           // Получаем q0 q1 q2 q3 q4 q5  
            //i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();

            //arr[3] = arr[2];
            //i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();

            //arr[4] = arr[3];
            //i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();

            //arr[5] = arr[4];
            //i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();

            //t = arr[5];
            //i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();

            //arr[0] = t;
            //i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();



            //t = arr[5];                // Гипотеза 1 

            //int i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();

            //arr[0] = t;                // Получаем y0 y1 y2 y3 y4 y5  
            //i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();

            //arr[1] = arr[0];
            //i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();

            //arr[2] = arr[1];
            //i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();

            //arr[3] = arr[2];
            //i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();

            //arr[4] = arr[3];
            //i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();

            //arr[5] = arr[4];
            //i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write(" " + arr[i] + " " + i);
            //    i = i + 1;
            //}
            //Console.WriteLine();

            //t = arr[5];

            i = 0;
            while (i < arr.Length)
            {
                Console.Write(" " + arr[i] + " " + i);
                i = i + 1;
            }
            Console.WriteLine();

        }
    }
}
