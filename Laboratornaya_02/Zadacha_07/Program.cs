using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;                
            a = Console.ReadLine();  
            double A;                
            A = double.Parse(a);     
            double B;
            B = A * Math.PI / 180;
            Console.WriteLine("{0:F4}", B);
            
            
        }
    }
}
