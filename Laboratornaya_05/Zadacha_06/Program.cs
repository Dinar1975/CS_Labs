using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string v1;
            v1 = Console.ReadLine();
            double V1km_h;
            V1km_h = double.Parse(v1);

            double V1m_s;
            V1m_s = V1km_h * 1000 / 3600;

            string v2;
            v2 = Console.ReadLine();
            double V2m_s;
            V2m_s = double.Parse(v2);

            if (V1m_s < 0) // Если значение меньше нуля
            {
                Console.WriteLine("Значение V1 должно быть неотрицательным");
                return;
            }
            
            if (V2m_s < 0)    // Если V2 мееньше нуля
            {
                Console.WriteLine("Значение V2 должно быть неотрицательным");
                return;
            }

            if (V2m_s < V1m_s)   
            {
                Console.WriteLine("V2 (м/с) меньше V1(км/ч)");                
            }
            else  
            {
                Console.WriteLine("V1(км/ч) меньше V2(м/ с)");                
            }
                
          

             

        }
    }
}
