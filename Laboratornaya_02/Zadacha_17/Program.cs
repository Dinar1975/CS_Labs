using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string v1;                 // Скорость первой машины
            v1 = Console.ReadLine();
            double V1;
            V1 = double.Parse(v1);
            
            string v2;                 // Скорость второй машины
            v2 = Console.ReadLine();
            double V2;
            V2 = double.Parse(v2);                    
            string s;                  // Расстояние между машинами

            s = Console.ReadLine();
            double S;
            S = double.Parse(s);


            if (V1 < 0)  // Если V1 меньше нуля
            {
                // Выводим сообщение
                Console.WriteLine("Значение V1 должно быть неотрицательным");
                return;   // Завершаем работу программы 
            }
            
            if (V2 < 0) // Если V2 меньше нуля 
            {
                // Выводим сообщение
                Console.WriteLine("Значение V2 должно быть неотрицательным");
                return;   // Завершаем работу программы
            }

            double T;            
            T = S / (V1 + V2);         // Время через которое машины встретятся
            Console.WriteLine("{0:F4}", T);
             

        }
    }
}
