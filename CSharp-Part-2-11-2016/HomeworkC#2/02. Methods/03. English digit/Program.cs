using System;

namespace _03.English_digit
{
    class Program
    {
        static string GetDigitWord(int digit)
        {
            string[] words = {"zero", "one", "two", "three", "four", "five",
                          "six", "seven", "eight", "nine", "ten"};
           return words[digit] ;
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int digit = number % 10;
            Console.WriteLine(GetDigitWord(digit));
        }
    }
}
