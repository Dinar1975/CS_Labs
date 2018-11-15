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

            //                                                  // Гипотеза 8
            //Console.WriteLine(0 + "," + 5);
            //Console.WriteLine(5 + "," + 4);
            //Console.WriteLine(4 + "," + 3);
            //Console.WriteLine(3 + "," + 2);
            //Console.WriteLine(2 + "," + 1);
            //Console.WriteLine(1);

            //int l = 0;
            //int r = 5;
            //Console.WriteLine(l + "," + r);
            //l = l + 5;
            //r = r - 1;
            //Console.WriteLine(l + "," + r);
            //l = l - 1;
            //r = r - 1;
            //Console.WriteLine(l + "," + r);
            //l = l - 1;
            //r = r - 1;
            //Console.WriteLine(l + "," + r);
            //l = l - 1;
            //r = r - 1;
            //Console.WriteLine(l + "," + r);
            //Console.WriteLine(1);



            //int l = 0;
            //int r = 5;
            //Console.WriteLine(l + "," + r);
            //l = l + 5;
            //r = r - 1;
            ////Console.WriteLine(l + "," + r);
            //while (l > 1)
            //{
            //    Console.WriteLine(l + "," + r);
            //    l = l - 1;
            //    r = r - 1;
            //}
            //Console.WriteLine(1);

            //t = arr[0];                                     // Гипотеза 7
            //int l = 0;
            //int r = 5;                        
            //arr[0] = arr[r];    // n=0

            //l = l + 5;
            //r = r - 1;
            //arr[l] = arr[r];    // n=5

            //l = l - 1;
            //r = r - 1;
            //arr[l] = arr[r];    // n=4

            //l = l - 1;
            //r = r - 1;
            //arr[l] = arr[r];    // n=3

            //l = l - 1;
            //r = r - 1;
            //arr[l] = arr[r];    // n=2

            //arr[1] = t;         // n=1

            
            int l = 0;
            int r = arr.Length;
            r = r - 1;
            arr[l] = arr[r];
            Console.WriteLine(l + "," + r);

            arr[l] = arr[r];
            l = l + arr.Length-1;
            r = r - 1;            
            while(l > 1)
            {
                arr[l] = arr[r];
                Console.WriteLine(l + "," + r);
                l = l - 1;
                r = r - 1;
            }
            arr[l] = t;
            Console.WriteLine(1);
            //arr[n] = arr[n+5];
            //arr[n+5] = arr[n+4];
            //arr[n+4] = arr[n+3];
            //arr[n+3] = arr[n+2];
            //arr[n+2] = arr[n+1];
            //arr[n+1] = t;

            int i = 0;

            while (i < arr.Length)
            {
                Console.WriteLine(" " + arr[i] + i);
                i = i + 1;
            }
            Console.WriteLine();


        }
    }
}
