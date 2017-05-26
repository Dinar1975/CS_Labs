using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);
            string b;
            b = Console.ReadLine();
            double B;
            B = double.Parse(b);
            if (A < B)
            {
                Console.WriteLine("Второе");                
            }
            else
            {
                Console.WriteLine("Первое");

            }
            
        }
    }
}
