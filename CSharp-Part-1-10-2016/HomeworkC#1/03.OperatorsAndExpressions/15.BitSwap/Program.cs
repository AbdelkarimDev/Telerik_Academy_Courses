using System;


namespace _15.BitSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine().PadLeft(32, '0'));
            uint numP, bit1, bit2, mask1, mask2;
            byte p = byte.Parse(Console.ReadLine());
            byte q = byte.Parse(Console.ReadLine());
            byte k = byte.Parse(Console.ReadLine());
            byte temp;
            if (p > q)
            {
                temp = p;
                p = q;
                q = temp;
            }
            for (int i = 0; i < k; i++)
            {
                numP = num >> (p + i);
                bit1 = numP & 1;
                numP = num >> (q + i);
                bit2 = numP & 1;
                bit1 = bit1 << (q + i);
                bit2 = bit2 << (p + i);
                mask1 = 1U << (p + i);
                num = num & ~mask1;
                mask2 = 1U << (q + i);
                num = num & ~mask2;
                num = num | bit1;
                num = num | bit2;

            }
            Console.WriteLine(num);
        }
    }
}
  