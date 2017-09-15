using System;


namespace _02.Binary_to_decimal
{
    class Program
    {

        static long BinToDec(string number, int NumeralBase = 8)
        {
            long result = 0;
            foreach (char digit in number)
            {
                result = result * NumeralBase + (digit - '0');
            }

            return result;
        }


        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(BinToDec(number));
        }
    }
}
