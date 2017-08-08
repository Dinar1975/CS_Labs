using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);

            if ((A > 9999) && (A < 1000))
            {
                Console.WriteLine("Значение A должно быть в интервале [1000, 9999]");
                return;
            }



            int n1;          // единицы
            int n2;          // сотни

            n1 = A % 10;
            n2 = A / 100 % 10;

            
            if (n1 != n2)
            {
                Console.WriteLine("Не равно");

            }
            else
            {
                Console.WriteLine("равно");
            }

        }
    }
}
