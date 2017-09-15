using System;

namespace _05.ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isThirdDigitseven = (n / 100) % 10 == 7;
            if (isThirdDigitseven)
            {
                Console.WriteLine("{0}", isThirdDigitseven.ToString().ToLower());

            }
            else
            {
                Console.WriteLine("{0} {1}", isThirdDigitseven.ToString().ToLower(), (n / 100) % 10);
            }
        }
    }
}
