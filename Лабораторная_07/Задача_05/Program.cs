using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_05
{
    class Program
    {
        static void Main(string[] args)
        {
            String b;
            b = Console.ReadLine();
            int B = int.Parse(b);

            String e;
            e = Console.ReadLine();
            int E = int.Parse(e);

            String data;
            data = Console.ReadLine();

            String[] arr = data.Split(' ');

            int i = 0;
            {
                Console.WriteLine("0");                
            }

            {
                Console.WriteLine("1");
            }

            {
                Console.WriteLine("2");
            }

            {
                Console.WriteLine("3");
            }

            




            if (B == 0 || arr.Length <= E)
            {
                Console.WriteLine(" Число B должно быть в интервале [0, " + arr.Length + "]");
                i = i + 1;
            }
            Console.WriteLine(arr[i] + " " + i);



        }
    }
}
