using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] arr = data.Split(' ');

            int n = 0;               // количество элементов массива
            int element;         // значение элемента массива

            double sum = 0;          //  сумма значений эл-ов массива
            double AVG = 0;          // среднесреднееарифметическое от деления суммы на количество эл-тов
            double Otkl = 0;         // Абсолютное отклонение каждого элемента от среднеарифметич. каждого значений 

            while (n < arr.Length)
            {
                element = int.Parse(arr[n]); // преобразует значение элемента массива в число
                sum = sum + element;         // складываем n раз                 
                n = n + 1;
            }

            
            AVG = sum / n;             // и делим сумму на количество один раз 
            Console.WriteLine(AVG);
            
            
            n = 0;
            while (n < 0 || arr.Length > n)
            {
                Otkl = Math.Abs(int.Parse(arr[n]) - AVG);      // расчитываем отклонение как разницу между значением элемента и среднеарифметич. значением
               Console.WriteLine("{0}", Otkl);   
                n = n + 1;
                
                
                //R = Math.Abs(A);
                //Console.WriteLine("{0}", R);
            
            
            }
            
          
            
            

        }
    }
}
