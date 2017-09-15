using System;
using System.Linq;

namespace _02.Get_largest_number
{
    class Program

    {
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }
        static void Main(string[] args)
        {
             int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int biggestValue = GetMax(GetMax(numbers[0], numbers[1]), numbers[2]);
            Console.WriteLine("{0}", biggestValue);
        }
    }
}
