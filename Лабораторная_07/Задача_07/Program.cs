using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_07
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            data = Console.ReadLine();

            String[] arr = data.Split(' ');

            String t = arr[0];

            t = arr[0];                                     // Гипотеза 7
            int i = 0;
            arr[0] = arr[5];
            arr[5] = arr[4];
            arr[4] = arr[3];
            arr[3] = arr[2];
            arr[2] = arr[1];
            arr[1] = t;

            while (i < arr.Length)
            {
                Console.WriteLine(" " + arr[i] + i);
                i = i + 1;
            }
            Console.WriteLine();
                        

        }
    }
}
