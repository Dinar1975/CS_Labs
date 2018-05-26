using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_01
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            int A = int.Parse(a);

            String data;
            data = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(data))     // Если строка пуста или в ней только пробелы
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }
            String[] arr = data.Split(' ');

            if (A < 0 || arr.Length <= A)    // Ошибка если А больше или равна длине массива или меньше нуля 
            {
                Console.WriteLine("Число A должно быть в интервале [0, " + arr.Length + ")");
                return;
            }

            Console.WriteLine(arr[A]);

        }
    }
}
