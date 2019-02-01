using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String M = Console.ReadLine();
            int m = int.Parse(M);
            String[] arr = data.Split(' ');
            int element;         //значение элемента массива
            int product;

            int n=0;
            while (n < arr.Length)
            {
                element = int.Parse(arr[n]); // преобразует значение элемента массива в число
                product = element * m;
                Console.WriteLine(product);
                n = n + 1;
            }


            //element = int.Parse(arr[0]);
            //product = element * m;
            //Console.WriteLine(product);
            //element = int.Parse(arr[1]);
            //product = element * m;
            //Console.WriteLine(product);
            //element = int.Parse(arr[2]);
            //product = element * m;
            //Console.WriteLine(product);
            //element = int.Parse(arr[3]);
            //product = element * m;
            //Console.WriteLine(product);
            //element = int.Parse(arr[4]);
            //product = element * m;
            //Console.WriteLine(product);
            //element = int.Parse(arr[5]);
            //product = element * m;
            //Console.WriteLine(product);            
        }
    }
}
