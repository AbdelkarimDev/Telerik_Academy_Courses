using System;


namespace _01.Numbers_from_1_to_N
{
    class Startup
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.Write("{0} ",i);
            }
        }
    }
}
