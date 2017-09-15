using System;
//Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.

//    Use only one loop.Print the result with 5 digits after the decimal point.


namespace _05.Calculate_
{
    class Program
    {
        static void Main()
        {
            decimal N = decimal.Parse(Console.ReadLine());
            decimal x = decimal.Parse(Console.ReadLine());
            decimal ResultNFacturel = 1;
            decimal ResultxN = x;
            decimal Sum = 1;

            for (decimal i = 1; i <= N; i++)
            {
                ResultNFacturel *= i;

                decimal Result = ResultNFacturel / ResultxN;
                Sum += Result;
                ResultxN *= x;
            }
            Console.WriteLine("{0:F5}", Sum);
        }
    }

}
