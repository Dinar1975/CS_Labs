using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);

            string y;
            y = Console.ReadLine();
            double Y;
            Y = double.Parse(y);

            if ((X >= 1) && (Y <= -1))
                
            {
                Console.WriteLine("точка с координатами {0}, {1} принадлежит заданному множеству область 1", X, Y);
            }

            else
            {
                Console.WriteLine("точка с координатами {0}, {1} не принадлежит заданному множеству область 1", X, Y);
            }

            if ((X >= 2) && (Y >= 0)) 
               
            {
                Console.WriteLine("точка с координатами {0}, {1} принадлежит заданному множеству область 2", X, Y);
            } 

            else
            {
                Console.WriteLine("точка с координатами {0}, {1} не принадлежит заданному множеству область 2", X, Y);
            }

        }
    }
}
