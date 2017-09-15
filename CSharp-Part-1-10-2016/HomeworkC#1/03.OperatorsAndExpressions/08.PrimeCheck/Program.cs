using System;


namespace _08.PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = int.Parse(Console.ReadLine());
            bool isPrime = true;
         
            for (int i = 2; i <= Math.Sqrt(Num); i++)
            {
                if (Num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (Num == 1 || Num < 1)
            {
                isPrime = false;
            }
            Console.WriteLine(isPrime.ToString().ToLower());
        }
    }
}





