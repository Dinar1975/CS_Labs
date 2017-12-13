using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);

            if (A < 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }

            string b;
            b = Console.ReadLine();
            
            int i;
            i = 0;

            Console.Write("\"");

            while (i < A)
            {
                Console.Write(b);
                i = i + 1;
            }

            Console.WriteLine("\"");

        }
    }
}
