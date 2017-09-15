using System;


namespace _02.Not_Divisible_Numbers
{
    class Statup
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write("{0} ", i);

                }
        
            }

        }
    }
}
