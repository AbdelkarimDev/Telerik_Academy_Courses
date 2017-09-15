using System;
using System.Numerics;

namespace _16.Trailing_0_in_N_
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int divider = 5;
            while (n / divider >= 1)
            {
                counter += n / divider;
                divider *= 5;
            }
            Console.WriteLine(counter);
        }
    }

}
 