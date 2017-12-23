using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            x = Console.ReadLine();
            int X;
            X = int.Parse(x);

            int I;
            I = 10;

            //if (X != I)
            //{
            //    Console.WriteLine(I);
            //}
            //else
            //{
            //    Console.WriteLine(I + "+");
            //}
            //I = I + 1;

            //if (X != I)
            //{
            //    Console.WriteLine(I);

            //}
            //else
            //{
            //    Console.WriteLine(I + "+");
            //}
            //I = I + 1;

            //if (X != I)
            //{
            //    Console.WriteLine(I);                
            //}
            //else
            //{
            //    Console.WriteLine(I + "+");
            //}
            //I = I + 1;

            //if (X != I)
            //{
            //    Console.WriteLine(I);                
            //}
            //else
            //{
            //    Console.WriteLine(I + "+");
            //}
            //I = I + 1;

            while (I >= 10 && I <= 20)
            {
                if (X != I)
                {
                Console.WriteLine(I);                
                }
                else
                {
                Console.WriteLine(I + "+");
                }
                I = I + 1;
            }

        }
    }
}
