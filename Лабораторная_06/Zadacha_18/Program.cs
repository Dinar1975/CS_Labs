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
            int sum = 0;
            int n = 0;

            string data;
            int a;

            //if (sum <= 1000)
            //{
            //    sum = sum + a;
            //    n = n + 1;

            //    data = Console.ReadLine();
            //    a = int.Parse(data);
            //}
            
            //if (sum <= 1000)
            //{
            //    sum = sum + a;
            //    n = n + 1;

            //    data = Console.ReadLine();
            //    a = int.Parse(data);
            //}

            do
            {
                
                data = Console.ReadLine();
                a = int.Parse(data);                
                
                sum = sum + a;
                n = n + 1;

            }

            while (sum <= 1000);

            Console.WriteLine("Количество чисел:" + n);


        }
    }
}
