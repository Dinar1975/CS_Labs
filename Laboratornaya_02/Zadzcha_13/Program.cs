using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadzcha_13
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
            if (x > 61) // Если значение больше или равно 61
            {
                // Выводим сообщение об ошибке
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return; // Завершаем работу программы

            }

            // Проверяем перед расчетом результата           
            
            double R;
            R = 3 * Math.Sqrt(61-x);
            Console.WriteLine("{0:F4}", R);
                        
        }
    }
}
