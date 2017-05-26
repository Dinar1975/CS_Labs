using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_03
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;                //  объявляем переменную а
            a = Console.ReadLine();  //  ввод значения
            double A;                //  объявляем переменную для хранения значения введенного пользователем
            A = double.Parse(a);     //  преобразуем строку а в число А
           
            // Проверяем после преобразования данных
            if (A <= 0) // Если значение меньше или равно нулю
            {
                // Выводим сообщение об ошибке
                Console.WriteLine("Значение А должно быть положительным");
                return; // Завершаем работу программы

            }

            // Проверяем перед расчетом результата
                      
            
            double V;                //  объявляем переменную V для хранения результата       
            V = A * A * A;           //  формула вычисления
            Console.WriteLine("{0:F4}", V);  // вывод на экран значения V
        }
    }
}
