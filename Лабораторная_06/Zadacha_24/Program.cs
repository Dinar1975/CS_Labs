using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_24
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
            I = 30;

            //if (X != I)
            //{
            //    Console.WriteLine(I + "-");
            //}
            //else
            //{
            //    Console.WriteLine(I + "+");
            //}
            //I = I + 1;

            //if (X != I)
            //{
            //    Console.WriteLine(I + "-");

            //}
            //else
            //{
            //    Console.WriteLine(I + "+");
            //}
            //I = I + 1;

            //if (X != I)
            //{
            //    Console.WriteLine(I + "-");                
            //}
            //else
            //{
            //    Console.WriteLine(I + "+");
            //}
            //I = I + 1;

            //if (X != I)
            //{
            //    Console.WriteLine(I + "-");                
            //}
            //else
            //{
            //    Console.WriteLine(I + "+");
            //}
            //I = I + 1;

            while (I >= 30 && I <= 40)
            {
                if (X != I)
                {
                    Console.WriteLine(I + "-");
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
