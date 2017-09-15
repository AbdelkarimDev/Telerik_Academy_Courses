using System;

//Write a program that calculates N! / K! for given N and K.

//    Use only one loop.

namespace _06.Calculate_Again_
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            decimal Result=1;
            for (decimal i = K+1; i <= N; i++)
            {
                Result *= i;
            }
            Console.WriteLine(Result);

        }

    }
}
