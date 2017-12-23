using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 0;

            String data;
            int a;

            data = Console.ReadLine();
            a = int.Parse(data);

            //if (a != 0)
            //{
            //    sum = sum + a;
            //    n = n + 1;

            //    data = Console.ReadLine();
            //    a = int.Parse(data);                
            //}
            //if (a!= 0)
            //{
            //    sum = sum + a;
            //    n = n + 1;

            //    data = Console.ReadLine();
            //    a = int.Parse(data);                
            //}

            while (a != 0)
            {
                sum = sum + a;
                n = n + 1;

                data = Console.ReadLine();
                a = int.Parse(data);
            }
            Console.WriteLine("Сумма чисел: {0}, Количество чисел: {1}", sum, n);

        }
    }
}
