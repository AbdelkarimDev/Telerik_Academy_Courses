﻿using System;


namespace _06.Quadratic_Equation
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double Discriminant = (b * b) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(Discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(Discriminant)) / (2 * a);
            if (Discriminant < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                if (Discriminant == 0)
                {
                    Console.WriteLine("{0:F2}", x1);
                }
                else
                {
                    Console.WriteLine("{0:F2}", Math.Min(x1, x2));
                    Console.WriteLine("{0:F2}", Math.Max(x1, x2));
                }
            }


        }


    }
}

