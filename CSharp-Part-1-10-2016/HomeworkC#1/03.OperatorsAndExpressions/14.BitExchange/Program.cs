using System;
//Write a program that exchanges bits 3, 4 and 5 
//    with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).

namespace _14.BitExchange
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Please enter number:");
            uint num = uint.Parse(Console.ReadLine());
            uint numP, bit1, bit2, mask1, mask2;

            for (int i = 0; i < 3; i++)
            {
                // get bit 3 (,4,5)
                numP = num >> (3 + i);
                bit1 = numP & 1;
                // get bit 24 (,25,26)
                numP = num >> (24 + i);
                bit2 = numP & 1;
                // shift bit 3 (,4,5) to positon 24 (,25,26)
                bit1 = bit1 << (24 + i);
                // shift bit 24 (,25,26) to position 3 (,4,5)
                bit2 = bit2 << (3 + i);
                // set bit 3 (,4,5) to zero
                mask1 = 1U << (3 + i);
                num = num & ~mask1;
                // set bit 24 (,25,26) to zero
                mask2 = 1U << (24 + i);
                num = num & ~mask2;
                // put bit 3 (,4,5) in bit 24 (,25,26)
                num = num | bit1;
                // put bit 24 (,25,26) in bit 3 (,4,5)
                num = num | bit2;
                           
            }
            Console.WriteLine(num);
        }
    }
}

    //for (int i = 0; i < 3; i++)
                //{
                //    firstBit = 3 + i;
                //    secondBit = 24 + i;
                //    Console.WriteLine((number >> secondBit) % 2);
                //    result = ((number >> firstBit) % 10) == 1 ? result | (1U << secondBit) : result & ~(1U << secondBit);
                //    result = ((number >> secondBit) % 10) == 1 ? result | (1U << firstBit) : result & ~(1U << firstBit);
                //}

                //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                //Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));

