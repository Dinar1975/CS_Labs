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
            Console.WriteLine("Введите число S");
            String s;
            s = Console.ReadLine();
            int S;
            S = int.Parse(s);

            Console.WriteLine("Введите данные");
            String data;
            data = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(data))    // Если строка пуста или в ней только пробелы
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }
            
            String[] arr = data.Split(' ');
            String t = arr[0];

            int l = 0;
            int r = arr.Length;
            r = r - 1;
            arr[l] = arr[r];
            Console.WriteLine(l + "," + r);
            arr[l] = arr[r];
            l = l + arr.Length - 1;
            r = r - 1;

            while (l > 1)
            {
                arr[l] = arr[r];
                Console.WriteLine(l + "," + r);
                l = l - 1;
                r = r - 1;
            }

            arr[l] = t;
            Console.WriteLine(1);

            int i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(" " + arr[i] + " " + i);
                i = i + 1;

            }

            Console.WriteLine();

            l = 0;
            r = arr.Length;
            r = r - 1;
            arr[l] = arr[r];
            Console.WriteLine(l + "," + r);
            arr[l] = arr[r];
            l = l + arr.Length - 1;
            r = r - 1;

            while (l > 1)
            {
                arr[l] = arr[r];
                Console.WriteLine(l + "," + r);
                l = l - 1;
                r = r - 1;
            }

            arr[l] = t;
            Console.WriteLine(1);

            i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(" " + arr[i] + " " + i);
                i = i + 1;

            }

            Console.WriteLine();



        }
    }
}
