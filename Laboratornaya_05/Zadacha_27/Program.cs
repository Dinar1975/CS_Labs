using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);
                       
            int n1;       // единицы
            n1 = A % 10;
            
            if ((n1 == 1) || (n1 == 4) || (n1 == 5) || (n1 == 9))            
            {
                Console.WriteLine("{0}-ый", A);
            }

            if ((n1 == 0) && (A != 40))
            {
                Console.WriteLine("{0}-ый", A);
            }

            if (A == 40)
            {
                Console.WriteLine("{0}-ой", A);
            }

            if ((A == 12) || (A == 13) || (A == 16) || (A == 17) || (A == 18))
            {
                Console.WriteLine("{0}-ый", A);
            }

            if ((n1 == 3) && (A!= 13))
            {
                Console.WriteLine("{0}-ий", A);
            }

            if (((n1 == 6) || (n1 == 7) || (n1 == 8)) && (A != 16) && (A != 17) && (A != 18))
            {
                Console.WriteLine("{0}-ой", A);
            }

            if (( n1 == 2) && (A != 12))
            {
                Console.WriteLine("{0}-ой", A);
            }

        }        
    }
}
