using System;

namespace _11._3rdBit
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine((number >> 3) & 1);
        }
    }
}
