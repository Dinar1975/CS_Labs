using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_30
{
    class Program
    {
        static void Main(string[] args)
        {
            string xt;
            xt = Console.ReadLine();
            double XT;
            XT = double.Parse(xt);

            if (XT < 0)
            {
                Console.WriteLine("Координата X должна быть неотрицательной");
                return;
            }

            string yt;
            yt = Console.ReadLine();
            double YT;
            YT = double.Parse(yt);

            string xp1;
            xp1 = Console.ReadLine();
            double XP1;
            XP1 = double.Parse(xp1);

            string yp1;
            yp1 = Console.ReadLine();
            double YP1;
            YP1 = double.Parse(yp1);

            string xp2;
            xp2 = Console.ReadLine();
            double XP2;
            XP2 = double.Parse(xp2);

            string yp2;
            yp2 = Console.ReadLine();
            double YP2;
            YP2 = double.Parse(yp2);

            if ((YP1 - YP2) * XT + (XP2 - XP1) * YT + (XP1 * YP2) - (XP2 * YP1) = 0)            
            {
                Console.WriteLine("точка принадлежит прямой");
            }

            else

            {
                Console.WriteLine("точка не принадлежит прямой");
            }
        }
    }
}
