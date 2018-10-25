using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            String p;
            p = Console.ReadLine();
            int P = int.Parse(p);

            String q;
            q = Console.ReadLine();
            int Q = int.Parse(q);

            string data;
            data = Console.ReadLine();

            String[] arr = data.Split(' ');

            String t = arr[0];

            arr[0] = arr[3];

            arr[3] = t;

            int i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(arr[i] + " " + i);
                i = i + 1;
            }
        }
    }
}
