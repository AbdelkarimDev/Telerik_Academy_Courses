using System;


namespace _07.One_system_to_any_other
{
    class Program
    {
        static long ConvertHexToDec(string number, int FromBase)
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
                    digitValue = digit - 'A' + 10;
                }

                result = FromBase * result + digitValue;
            }

            return result;
        }
        static string DecToHex(long value, int ToBase)
        {
            string result = "";
            string hexDigit = "0123456789ABCDEF";

            do
            {
                long digitValuie = value % ToBase;
                char digit = hexDigit[(int)digitValuie];
                value /= ToBase;
                result = digit + result;
            }
            while (value > 0);

            return result;

        }


        static void Main()
        {
            int FromBase = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            int ToBase = int.Parse(Console.ReadLine());

            long DecSystem = ConvertHexToDec(number, FromBase);
            string NewNumber = DecToHex(DecSystem, ToBase);
            Console.WriteLine(NewNumber);
        }
    }
}

