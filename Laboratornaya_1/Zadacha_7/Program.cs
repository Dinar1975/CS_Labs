using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String m;
            m = Console.ReadLine(); // Получаем информацию от пользователя и записываем переменную "м"
            double a; // Объявляем переменную "а" для хранения дробного числа
            a = double.Parse(m); // Преобразуем строку в дробное число
            Console.WriteLine("{0:F4}", a); // Выводим значение "а" с точностью четыре знака после запятой
        }
    }
}
