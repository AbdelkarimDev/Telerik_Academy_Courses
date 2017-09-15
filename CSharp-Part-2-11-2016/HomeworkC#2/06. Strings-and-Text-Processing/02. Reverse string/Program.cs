using System;
using System.Text;

namespace _02.Reverse_string
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string reverseInput = Reverse(input);
            Console.WriteLine(reverseInput);
        }

        static string Reverse(string input)
        {
            StringBuilder reversedResult = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedResult.Append(input[i]);
            }
            return reversedResult.ToString();
        }
    }
}
