using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string m;
            m = Console.ReadLine();
            double M;
            M = double.Parse(m);
            string v;
            v = Console.ReadLine();
            double V;
            V = double.Parse(v);
            string h;
            h = Console.ReadLine();
            double H;
            H = double.Parse(h);

            if (M < 0)              // Если М меньше нуля
            {
                // Выводим сообщение
                Console.WriteLine("Значение M должно быть положительным");
                return;   // Завершаем работу программы 
            }


            double T;
            T = M * V * V / 2;
            Console.WriteLine("{0:F4}", T);

            double Wn;
            Wn = M * 9.8067 * H;
            Console.WriteLine("{0:F4}", Wn);
        }
    }
}
