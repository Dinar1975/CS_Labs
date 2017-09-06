using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(8 + " ");
            //Console.WriteLine(9 + " ");
            //Console.WriteLine(10 + " ");
            //Console.WriteLine(11 + " ");
            //Console.WriteLine(12 + " ");
            //Console.WriteLine(13 + " ");

            //int a;
            //a = 8;                       
            //Console.WriteLine(a + " ");
            //a = a + 1;
            //Console.WriteLine(a + " ");
            //a = a + 1;
            //Console.WriteLine(a + " ");
            //a = a + 1;
            //Console.WriteLine(a + " ");
            //a = a + 1;
            //Console.WriteLine(a + " ");
            //a = a + 1;
            //Console.WriteLine(a + " ");

            string a;
            a = Console.ReadLine(); 
            int A;
            A = int.Parse(a);
                        
            string b;
            b = Console.ReadLine();
            int B;
            B = int.Parse(b);

            if (A > B)
            {
                Console.WriteLine("Значение A должно быть не больше значения B");
                return;
            }

                        
            while (A <= B)
            {
                Console.WriteLine(A + " ");
                A = A + 1;
            }

        


        }
    }
}
