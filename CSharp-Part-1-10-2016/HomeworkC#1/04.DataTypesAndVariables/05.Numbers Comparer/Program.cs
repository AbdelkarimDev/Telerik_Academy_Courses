﻿using System;


namespace _05.Numbers_Comparer
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a > b ? a : b);
        }
    }
}
