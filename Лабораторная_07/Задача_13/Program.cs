using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] arr = data.Split(' ');
            int n=0;               // количество элементов массива
            int element;         // значение элемента массива
            
            int sum=0;          //  сумма значений эл-ов массива
            int AVG=0;          // среднесреднееарифметическое от деления суммы на количество эл-тов

            while (n < arr.Length)  
            {
                element = int.Parse(arr[n]); // преобразует значение элемента массива в число
                sum = sum + element;         // складываем n раз                 
                                          
            }
                AVG = sum / n;              // и делим сумму на количество один раз 
                Console.WriteLine(AVG);    // ? должна выполняться 1 раз



        }
    }
}
