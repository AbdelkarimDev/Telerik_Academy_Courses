using System;

namespace _02.Random_numbers
{
    class RandomNumbers
    {
        static void Main()
        {
            Random randomNumbers = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomValues = randomNumbers.Next(100, 201);
                Console.WriteLine(randomValues);
            }
        }
    }
}
