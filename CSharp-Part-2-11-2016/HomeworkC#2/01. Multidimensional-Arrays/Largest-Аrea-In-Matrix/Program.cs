using System;

namespace LargestAreaInMatrix
{
    class LargestAreaInMatrix
    {

        static void GetArea(int[,] matrix, bool[,] isInSequence, ref int count, int r, int c, int n, int m)
        {
            if (!isInSequence[r, c])
            {
                isInSequence[r, c] = true;
                if ((c > 0) && !isInSequence[r, c - 1] && (matrix[r, c] == matrix[r, c - 1]))
                {
                    count++;
                    GetArea(matrix, isInSequence, ref count, r, c - 1, n, m);
                }
                if ((c < m - 1) && !isInSequence[r, c + 1] && (matrix[r, c] == matrix[r, c + 1]))
                {
                    count++;
                    GetArea(matrix, isInSequence, ref count, r, c + 1, n, m);
                }
                if ((r > 0) && !isInSequence[r - 1, c] && (matrix[r, c] == matrix[r - 1, c]))
                {
                    count++;
                    GetArea(matrix, isInSequence, ref count, r - 1, c, n, m);
                }
                if ((r < n - 1) && !isInSequence[r + 1, c] && (matrix[r, c] == matrix[r + 1, c]))
                {
                    count++;
                    GetArea(matrix, isInSequence, ref count, r + 1, c, n, m);
                }

            }
        }

        static void Main()
        {
            string[] inputNAndM = Console.ReadLine().Split(' ');
            int n = int.Parse(inputNAndM[0]);
            int m = int.Parse(inputNAndM[1]);
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }
            bool[,] isInSequence = new bool[n, m];
            int count = 1;
            int maxCount = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    count = 1;
                    GetArea(matrix, isInSequence, ref count, i, j, n, m);
                    maxCount = (count > maxCount) ? count : maxCount;
                }
            }

            Console.WriteLine(maxCount);
        }
    }
}
