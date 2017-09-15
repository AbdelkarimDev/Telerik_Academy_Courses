using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_number
{
    class Program
    {
        static void Main()
        {
            decimal input = decimal.Parse(Console.ReadLine());

            ReverseDigits(input);
        }

        private static void ReverseDigits(decimal input)
        {
            string inputAsStr = input.ToString();

            string output = string.Empty;

            for (int i = inputAsStr.Length - 1; i >= 0; i--)
            {
                output += inputAsStr[i];
            }

            //or second way convert to char array
            //char[] charArr = inputAsStr.ToCharArray();
            //Array.Reverse(charArr);

            //for (int i = 0; i < charArr.Length; i++)
            //{
            //    output += charArr[i];
            //}

            Console.WriteLine(output);
        }
    }
}
