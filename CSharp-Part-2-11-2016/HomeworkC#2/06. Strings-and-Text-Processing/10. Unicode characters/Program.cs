using System;


namespace _10.Unicode_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u{0:X4}", (int)(input[i]));
            }
        }
    }
}
