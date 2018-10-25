using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_03
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            data = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }
            String[] arr = data.Split(' ');

            int i = 0;
            while (i <= arr.Length - 1)          // Можно написать второй вариант i < arr.Length 
            {
                Console.WriteLine(arr[i] + " " + i);
                i = i + 1;

            }

        }
    }
}
