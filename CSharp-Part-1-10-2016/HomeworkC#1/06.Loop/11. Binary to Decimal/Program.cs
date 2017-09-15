using System;

namespace _11.Binary_to_Decimal
{
    class Program
    {
        static void Main()
        {

            String bin = Console.ReadLine();    // my binary "number" as a string
            int dec = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                // we start with the least significant digit, and work our way to the left
                if (bin[bin.Length - i - 1] == '0') continue;
                dec += (int)Math.Pow(2, i);
              
            }
            Console.WriteLine(dec);
        }
    }
}

