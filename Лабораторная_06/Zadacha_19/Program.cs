using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            string data;
            int a;

            do
            {
                data = Console.ReadLine();
                a = int.Parse(data);

                n = n + 1;

            }

            while (a > 83 && a < 199);

            Console.WriteLine("Количество чисел:" + n);



        }
    }
}
