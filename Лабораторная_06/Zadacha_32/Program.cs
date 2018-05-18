using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_32
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();

            string w;
            w = Console.ReadLine();
            int W;
            W = int.Parse(w);

            if (W <= 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
                return;
            }

            string h;
            h = Console.ReadLine();
            int H;
            H = int.Parse(h);
                                    
            if (H <= 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
                return;
            }

            int i = 0;
            int m = 1;

            while (m <= H)
            {
                i = 0;
                m = m + 1;
                
                while (i < W)
                {
                    Console.Write(s);
                    i = i + 1;
                    
                }                               
                         
            Console.WriteLine();
            }
            
            
            

            
        }
    }
}
