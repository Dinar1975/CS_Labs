using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_02
{
    class Program
    {
        static void Main(string[] args)
        {

            String data;
            data = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Исходная строка пуста"); // Если строка пуста или в ней только пробелы
                return;
            }

            String[] arr = data.Split(';');

            
            int n = 0;

            n = (arr.Length)/2;
                       
            Console.WriteLine("Индекс " + n + " элемент" + arr[n]);
            




        }
    }
}
