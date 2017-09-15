using System;
using System.Numerics;


//In combinatorics, the number of ways to choose N different members out of a group of N different
//    elements(also known as the number of combinations) is calculated by the following formula:
//    formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//    Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.

//  Try to use only two loops.


namespace _07.Calculate_3_
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger resultat1 = 1;
            int Diferens = N - K;
            BigInteger result2 = 1;

            for (int i = K + 1; i <= N; i++)
            {
                resultat1 *= i;
            }

            for (int i1 = 1; i1 <= Diferens; i1++) 
            {
                result2 *= i1;
            }
            BigInteger Result = resultat1 / result2;

            Console.WriteLine(Result);
        }
    }
}
