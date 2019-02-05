using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные");
            String data = Console.ReadLine();

            Console.WriteLine("ВВедите данные");
            String S = Console.ReadLine();
                        
            String[] arr = data.Split(' ');  // разбил элементы первого массива 
            String[] arr1 = S.Split(' ');    // разбил элементы второго массива

            if (arr.Length != arr1.Length)  // Если длины массивов разные
            {
                Console.WriteLine("Размеры массивов должны быть одинаковы");
                return;
            }
            
            int n = 0;               // количество элементов массива
            int element = 0;         // значение элемента первого массива
            int element1 = 0;        // значение элемента второго массива

            int proizv = 0;          //  произведение значений эл-ов массива
            
            while (n < arr.Length)
            {
                element = int.Parse(arr[n]);       // преобразует значение элемента массива в число
                element1 = int.Parse(arr1[n]);
                proizv = element * element1;         // умножаем n раз                 
                n = n + 1;

                Console.Write(proizv + " ");    // должна выполняться 1 раз
            }
            
            
        }
    }
}
