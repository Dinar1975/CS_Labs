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
            String cx;
            String cy;
            String r;
            String fill;
            cx = Console.ReadLine();  // Получаем информацию от пользователя и записываем в переменную "сx"
            cy = Console.ReadLine();  // Получаем информацию от пользователя и записываем в переменную "cy"
             r = Console.ReadLine();  // Получаем информацию от пользователя и записываем в переменную "r"
          fill = Console.ReadLine();  // Получаем информацию от пользовтеля и записываем в переменную "fill"
                 Console.WriteLine("<circle cx = '{0}' cy = '{1}' r = '{2}' fill = '{3}'>", cx, cy, r, fill);  // Выводим на экран значение            
        }
    }
}
