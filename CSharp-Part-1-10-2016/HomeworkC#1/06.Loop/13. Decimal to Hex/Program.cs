using System;
using System.Collections.Generic;
using System.Numerics;
namespace _13.Decimal_to_Hex
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Enter a number: ");
            long x = long.Parse(Console.ReadLine());
            int digit = 0;
            string letter = "";
            string hex = "";

            while (x != 0)
            {
                digit = (int)((x % 16));

                if (digit <= 9)
                {
                    hex = digit + hex;
                }
                else
                {
                    letter = digit.ToString();
                    switch (letter)
                    {
                        case "10": letter = "A"; break;
                        case "11": letter = "B"; break;
                        case "12": letter = "C"; break;
                        case "13": letter = "D"; break;
                        case "14": letter = "E"; break;
                        case "15": letter = "F"; break;
                    }
                    hex = letter + hex;
                }
                x = x / 16;
            }
            Console.WriteLine(hex);
        }
    }

}
    