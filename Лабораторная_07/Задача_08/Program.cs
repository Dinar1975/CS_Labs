using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_08
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            s = Console.ReadLine();
            int S = int.Parse(s);

            String data;
            data = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(data))    // Если строка пуста или в ней только пробелы
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }

            String[] arr = data.Split(' ');
            String t = arr[0];
            arr[0] = arr[5];
            arr[5] = t;



            int i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(" " + arr[i] + " " + i);
                i = i + 1;
            }




        }
    }
}
