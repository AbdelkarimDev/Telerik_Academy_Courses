using System;

namespace _09.Matrix_of_Numbers
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int row = 1; row <= N; row++)
            {
                for (int col = row; col <= row + (N - 1); col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
                {

                }
            }

        }
    }
}
