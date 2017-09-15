using System;


namespace _11.Interval
{
    class Program
    {
        static void Main()
        {
            uint N = uint.Parse(Console.ReadLine());
            uint M = uint.Parse(Console.ReadLine());
            uint count = 0;
            if (N <= M)
            {
                for (uint i = N + 1; i < M; i++)
                {
                    if (i % 5 == 0)
                    {
                        count++;
                    }

                }
                Console.WriteLine(count);
            }
        }
    }
}
