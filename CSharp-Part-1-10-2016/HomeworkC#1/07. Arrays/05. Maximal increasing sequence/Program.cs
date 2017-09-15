using System;


namespace _05.Maximal_increasing_sequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int length = 1;
            int bestLength = 0;


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i; k < array.Length - 1; k++)
                {
                    if (array[k] < array[k + 1])
                    {
                        length++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (bestLength <= length)
                {
                    bestLength = length;
                }
                length = 1;
            }
            Console.WriteLine(bestLength);
           

        }

    }
}

