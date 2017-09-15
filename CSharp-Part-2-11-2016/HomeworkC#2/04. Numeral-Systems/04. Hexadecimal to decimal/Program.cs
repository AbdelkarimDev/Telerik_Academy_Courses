using System;


namespace _04.Hexadecimal_to_decimal
{
    class Program
    {
        static long ConvertHexToDec(string number ,int NumeralBase = 16)
        {
            long result = 0;

            foreach (char digit in number)
            {
                long digitValue;
                if (char.IsDigit(digit))
                {
                    digitValue = digit - '0';
                }
                else
                {
                    digitValue = char.ToUpper(digit) - 'A' + 10;
                }

                result = 16 * result + digitValue;
            }
            
            return result;

        }
        static void Main()

        {
            string number = Console.ReadLine();
            Console.WriteLine(ConvertHexToDec(number));
        }
    }
}
