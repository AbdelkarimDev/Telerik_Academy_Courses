using System;


namespace _03.Decimal_to_hexadecimal
{
    class Program
    {
        static string DecToHex(long value, int numeralaBase = 16)
        {
            string result = "";
            string hexDigit = "0123456789ABCDEF";

            do
            {
                long digitValuie = value % numeralaBase;
                char digit = hexDigit[(int)digitValuie];
                    value /= numeralaBase;
                result = digit + result;
            }
            while (value > 0);

            return result;

        }

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(DecToHex(number));
        }
    }
}

