using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_29
{
    class Program
    {
        static void Main(string[] args)
        {
            string xt;
            xt = Console.ReadLine();
            double XT;
            XT = Double.Parse(xt);

            string yt;
            yt = Console.ReadLine();
            double YT;
            YT = double.Parse(yt);

            if (YT < 0)
            {
                Console.WriteLine("Координата Y должна быть неотрицательной");
                return;
            }
            
            string xp;
            xp = Console.ReadLine();
            double XP;
            XP = double.Parse(xp);

            string yp;
            yp = Console.ReadLine();
            double YP;
            YP = double.Parse(yp);

            string h;
            h = Console.ReadLine();
            double H;
            H = double.Parse(h);

            if (H <= 0)
            {
                Console.WriteLine("Высота должна быть положительной");
                return;
            }

            string w;
            w = Console.ReadLine();
            double W;
            W = double.Parse(w);
               
            if (W <= 0)
            {
                Console.WriteLine("Ширина должна быть положительна");
                return;
            }
          
            if ((XP + W > XT) && (YP + H > YT))

            {
                Console.WriteLine("точка внутри");
            }

            else
            {
                Console.WriteLine("точка не внутри");
            }

        }
    }
}
