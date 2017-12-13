using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_04
{
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.Write(B + " ");
                B = B - 1;
            }


        }
    }
}
