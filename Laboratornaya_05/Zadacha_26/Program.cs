﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_26
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

            if ((Y >= 0.5) && (Y <= 1.5) || (Y >= 1.5) && (Y <= 0.5) && (X >= 2) || (X >= 2))
            {
                Console.WriteLine("точка с координатами {0}, {1} принадлежит некоторому множеству", X, Y);
            }
            else
            {
                Console.WriteLine("точка с координатами {0}, {1} не принадлежит некоторому множеству", X, Y);
            }

        }
    }
}
