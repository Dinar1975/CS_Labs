using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string r;
            r = Console.ReadLine();
            double R;
            R = double.Parse(r);
            double V;
            V = 4 * Math.PI * R * R * R / 3;
            Console.WriteLine("{0:F4}", V);
            

        }
    }
}
