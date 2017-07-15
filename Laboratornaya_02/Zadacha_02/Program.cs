using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();  // Ввод значения
            double A;  // Объявляем переменную А для хранения значений введенного пользователем
            A = double.Parse(a);  // преобразуем строку а в число А, 
            
            // Проверяем после преобразования данных
            if (A<=0) // Если значение меньше или равно нулю
            {
                // Выводим сообщение об ошибке
                Console.WriteLine("Значение А должно быть положительным");
                return; // Завершаем работу программы
                
            }
            
            // Проверяем перед расчетом результата
            double C;  // Объявляем переменную С для хранения результата
            C = 6 * A * A;  // Формула вычисления
            Console.WriteLine("{0:F4}", C); // Вывод на экран значения С
              
        }
    }
}
