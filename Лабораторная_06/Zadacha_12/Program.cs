using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = - 10;

            Console.WriteLine("Введите число");

            string b;
            b = Console.ReadLine();
            int B;
            B = int.Parse(b);

            if (B < a || B > 10000)
            {
                Console.WriteLine("Значение b должно быть в интервале [-10,10000]");
                return;
            }

            int sum;
            sum = 0;
                        
            while (a <= B)
            {
                sum = sum + a;
                a = a + 1;
            }

            Console.WriteLine("Ответ:" + sum);
        }
    }
}
