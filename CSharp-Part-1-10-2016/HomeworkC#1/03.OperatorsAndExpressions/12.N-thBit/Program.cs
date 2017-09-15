using System;

namespace _12.N_thBit
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine((N >> P) & 1);

        }
    }
}
