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
            int n = 1;
            n = n - 1;
            arr[n] = arr[5];    // n=0
            n = n + 5;
            arr[n] = arr[4];    // n=5
            n = n - 1;
            arr[n] = arr[3];    // n=4
            n = n - 1;
            arr[n] = arr[2];    // n=3
            n = n - 1;
            arr[n] = arr[1];    // n=2
            n = n - 1;
            arr[n] = t;         // n=1





            //arr[n] = arr[n+5];
            //arr[n+5] = arr[n+4];
            //arr[n+4] = arr[n+3];
            //arr[n+3] = arr[n+2];
            //arr[n+2] = arr[n+1];
            //arr[n+1] = t;

            while (i < arr.Length)
            {
                Console.WriteLine(" " + arr[i] + i);
                i = i + 1;
            }
            Console.WriteLine();
                        

        }
    }
}
