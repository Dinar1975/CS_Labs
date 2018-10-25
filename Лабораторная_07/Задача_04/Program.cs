using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_04
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
            String[] arr = data.Split(',');

            Array.Reverse(arr);

            int i = 0;
            while (i < arr.Length)
            {
                Console.Write(arr[i] + " ");
                i = i + 1;
            }



        }
    }
}
