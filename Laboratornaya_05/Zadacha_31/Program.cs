using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_31
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1;
            a1 = Console.ReadLine();
            double A1;
            A1 = double.Parse(a1);

            string b1;
            b1 = Console.ReadLine();
            double B1;
            B1 = double.Parse(b1);

            string a2;
            a2 = Console.ReadLine();
            double A2;
            A2 = double.Parse(a2);

            string b2;
            b2 = Console.ReadLine();
            double B2;
            B2 = double.Parse(b2);

            if (A1 < A2 && B1 < B2 && A2 < B1) 
            {
                Console.WriteLine("пересекаются ({0}; {1})", A2, B1);
            }

            if (A2 > A1 && B1 > B2)
            {
                Console.WriteLine("пересекаются ({0}; {1})", A2, B2);
            }

            if (A2 < A1 && B2 < B1)
            {
                Console.WriteLine("пересекаются ({0}; {1})", A1, B2);
            }

            if (A2 < A1 && B1 < B2)
            {
                Console.WriteLine("пересекаются ({0}; {1})", A1, B1);
            }

            if (A1 > B1)
            {
                Console.WriteLine("не пересекаются");
            }

            if (A1 > B1 || A2 > B2)
            {
                Console.WriteLine("Значение A должно быть меньше значения B");
            }
        }
    }
}
