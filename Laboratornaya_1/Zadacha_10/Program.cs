using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_10
{
    class Program
    {
        static void Main(string[] args)
        {
            String x;  // Объявляем переменную "x" - для хранения строки
            String y;  // Объявляем переменную "y" - для хранения строки
            x = Console.ReadLine();  // Получаем информацию от пользователя и записываем в переменную "x"
            y = Console.ReadLine();  // Получаем информацию от пользователя и записываем в переменную "y"
            Console.WriteLine("INSERT INTO points (x, y) VALUES ('{0}', '{1}')", x, y);  // Выводим на экран значение

        }
    }
}
