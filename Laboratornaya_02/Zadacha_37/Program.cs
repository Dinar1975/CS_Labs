using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_37
{
    class Program
    {
        static void Main(string[] args)
        {
            string v1;
            v1 = Console.ReadLine();
            int V1;
            V1 = int.Parse(v1);
            if (V1 < 0)
            {
                Console.WriteLine("Объем должен быть неотрицательным");
                return;
            }
            
            string t1;
            t1 = Console.ReadLine();
            int T1;
            T1 = int.Parse(t1);

            string v2;
            v2 = Console.ReadLine();
            int V2;
            V2 = int.Parse(v2);
            if (V2 < 0)
            {
                Console.WriteLine("Объем должен быть неотрицательным");
                return;
            }

            string t2;
            t2 = Console.ReadLine();
            int T2;
            T2 = int.Parse(t2);

            int VL;
            VL = V1 + V2;
            Console.WriteLine("{0}", VL);

            int T;
            T = (T1 * V1 + T2 * V2) / (V1 + V2);
            Console.WriteLine("{0:F4}", T);
        }
    }
}
