using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            int T;
            T = int.Parse(t);
            if (T < 0)
            {
                Console.WriteLine("Значение T должно быть положительным");
                return;
            }

            string l;
            l = Console.ReadLine();
            int L;
            L = int.Parse(l);
            if (L < 0)
            {
                Console.WriteLine("Значение L должно быть положительным");
                return;
            }

            int R;
            R = T*100/L;
            int O;                        // объявляем остаток
            O = T * 100 % L;              // считаем остаток
            Console.WriteLine("{0} шт и {1} см", R, O);  // вывод отформатированного ответа

        }
    }
}
