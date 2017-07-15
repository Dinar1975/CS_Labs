using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string tc;
            tc = Console.ReadLine();
            double x;
            x = double.Parse(tc);
           
            // Проверяем после преобразования данных
            if (x < -273.15) // Если значение меньше -273.15
            {
                // Выводим сообщение 
                Console.WriteLine("Значение Т должно быть выше абсолютного нуля");
                return; // Завершаем работу программы
            }

            // Проверяем перед расчетом результата
            double tf;
            tf = x*1.8 + 32;
            Console.WriteLine("{0:F4}", tf);
        }
    }
}
