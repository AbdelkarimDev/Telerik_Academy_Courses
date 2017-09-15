using System;
using System.Numerics;


namespace _10.N_Factorial
{
    class Program
    {
        static BigInteger CalculationFactoriel(int n)
        {
            BigInteger factorial = 1;
            while (n > 1)
            {
                factorial *= n;
                n--;
            }
            return factorial;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Console.WriteLine(CalculationFactoriel(n));

        }
    }
}
