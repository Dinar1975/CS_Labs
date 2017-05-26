using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string r;
            r = Console.ReadLine();
            double R;
            R = double.Parse(r);
            
            // Проверяем после преобразования данных
            if (R <= 0) // Если значение меньше или равно нулю
            {
                // Выводим сообщение об ошибке
                Console.WriteLine("Значение R должно быть положительным");
                return; // Завершаем работу программы

            }

            // Проверяем перед расчетом результата
            
            double C;
            C = 2 * Math.PI * R;
            Console.WriteLine("{0:F4}", C);
            
        }
    }
}
