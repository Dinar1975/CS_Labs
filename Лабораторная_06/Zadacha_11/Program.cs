﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            
            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);

            if (A < -100 || A > 500)
            {
                Console.WriteLine("Значение A должно быть в интервале [-100, 500]");
                return;
            }

            int c;
            c = 500;

            int sum;
            sum = 0;

            while (A <= c)
            {
                sum = sum + A;
                A = A + 1;
            }

            Console.WriteLine("Ответ:" + sum);
        }
    }
}
