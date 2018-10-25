using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение Y от 0 до 15");

            string y;
            y = Console.ReadLine();
            int Y;
            Y = int.Parse(y);                       // Сколько нужно ввести
                                  

            if (Y < 0 || Y > 15)
            {
                Console.WriteLine("Значение Y должно быть в интервале [0, 15]");
                return;
            }

            int i = 0;                             // Сколько ввели уже
            int m = 15;                            // Сколько всего цифр

            while (i < Y)
            {
                Console.Write("#");

                if (m >= Y)
                {
                    Console.Write(".");
                    m = 0;
                }

                i = i + 1;
                m = m + 1;
            }


        }
    }
}

