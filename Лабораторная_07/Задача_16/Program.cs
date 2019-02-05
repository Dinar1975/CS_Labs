using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_16
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = "a b c d e f g h";
            String[] arr = data.Split(' ');
            String X = Console.ReadLine();

            int n = 0;         // количество элементов массива
            String element;    // значение элементов массива
                    


            if (X > 0 || X < arr[X])
            {
                element = int.Parse(arr[X]); // преобразуем элементы массива
                Console.WriteLine(arr[X]);  
            }
        }
    }
}
