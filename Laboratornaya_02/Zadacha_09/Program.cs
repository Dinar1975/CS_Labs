using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);
                                   
            int O;                         // объявляем остаток
            O = A % 360;               // считаем остаток 
            Console.WriteLine("{0}", O);

        }
    }
}
