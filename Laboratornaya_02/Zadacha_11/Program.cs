using System;
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
            string t;
            t = Console.ReadLine();
            double x;
            x = double.Parse(t);
            // Проверяем после преобразования данных
            if (x < 0) // Если значение меньше нуля
            {
                // Выводим сообщение об ошибке
                Console.WriteLine("Значение x должно быть неотрицательным");
                return; // Завершаем работу программы
            }

            // Проверяем перед расчетом результата 
                                   
            double R;
            R = Math.Sqrt(x);
            Console.WriteLine("{0:F4}", R);            

        }
    }
}
