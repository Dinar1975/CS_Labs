using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;  // объявляем переменную строковую
            string h;  // объявляем переменную строковую
            a = Console.ReadLine();  // считываем результат
            h = Console.ReadLine();  // считываем результат
            double A, H;             // объявляем дробную переменную
            A = double.Parse(a);     // преобразуем переменную в А
            H = double.Parse(h);     // преобразуем переменную в Н
            
            // Проверяем после преобразования данных
            if (A <= 0) // Если значение меньше или равно нулю
            {
                // Выводим сообщение об ошибке
                Console.WriteLine("Значение А должно быть положительным");
                return; // Завершаем работу программы
            }
            
            if (H<=0) // Если начение меньше или равно нулю
            {
                // Выводим сообщение об ошибке
                Console.WriteLine("Значение H должно быть положительным");
                return; // Завершаем работу программы                
            }

              // Проверяем перед расчетом результата
              
            double S;                // объявляем переменную дробную S
            S = A * H / 2;           // вычисляем результат
            Console.WriteLine("{0:F4}", S);  // выводим на экран

            
        }
    }
}
