using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);
            string y;
            y = Console.ReadLine();
            double Y;
            Y = double.Parse(y);
            
            // Проверяем после преобразования данных
                if (Y < 0) // Если значение меньше нуля
                {
                    // Выводим сообщение об ошибке
                    Console.WriteLine("Значение Y должно быть неотрицательным");
                    return; // Завершаем работу программы

                }

            // Проверяем перед расчетом результата

            // Проверяем после преобразования данных
            if (X + Math.Sqrt(Y) < 0) // Если подкоренное значение меньше нуля
            {
                // Выводим сообщение об ошибке
                Console.WriteLine("Подкоренное значение должно быть неотрицательным");
                return; // Завершаем работу программы

            }

            // Проверяем перед расчетом результата

            
            double R;
            R = -5 * Math.Sqrt(X + (Math.Sqrt(Y)));
            Console.WriteLine("{0:F4}", R);
        }
    }
}
