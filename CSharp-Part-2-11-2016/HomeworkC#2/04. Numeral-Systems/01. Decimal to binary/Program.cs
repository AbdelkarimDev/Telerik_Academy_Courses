using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Decimal_to_binary
{
    class Program
    {
        static string DecToBin(long value, int numeralaBase = 2)
        {
            string result = "";

            do
            {
                long digit = value % numeralaBase;
                value /= numeralaBase;
                result = digit + result;
            }
            while (value > 0);

                return result;

        }

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(DecToBin(number));
        }
    }
}
