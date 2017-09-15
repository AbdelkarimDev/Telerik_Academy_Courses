using System;

namespace _03.Sequence_in_matrix
{
    class SequenceInMatrix
    {
        static void Main(string[] args)
        {
            string[] inputdata = Console.ReadLine().Split(' ');

            int rows = int.Parse(inputdata[0]);
            int cols = int.Parse(inputdata[1]);

            int[,] matrix = new int[rows, cols];


            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }
            //int[,] matrix = {
            //    { 92, 11, 8, 11, 59, 48,},
            //    { 09, 92, 23, 8, 56, 14 },
            //    { 17, 63, 92, 46, 8, 95 },
            //    { 34, 12, 52, 69, 23, 8 },
            //    { 26, 88, 78, 71, 29, 95 },
            //    { 26, 34, 16, 63, 39, 95 },
            //};

            int length = 0;
            int maxLength = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //1. Check right direction
                    for (int k = j; k < matrix.GetLength(1); k++)
                    {
                        if (matrix[i, j] == matrix[i, k])
                        {
                            length++;
                        }
                    }
                    if (length >= maxLength)
                    {
                        maxLength = length;
                    }
                    length = 0;

                    //2. Check Bottom direction
                    for (int k = i; k < matrix.GetLength(0); k++)
                    {
                        if (matrix[i, j] == matrix[k, j])
                        {
                            length++;
                        }
                    }
                    if (length >= maxLength)
                    {
                        maxLength = length;
                    }
                    length = 0;

                    //3.Check right - bottom direction
                    for (int k = i, a = j; k < matrix.GetLength(0) && a < (matrix.GetLength(1) - 1); k++, a++)
                    {

                        if (matrix[i, j] == matrix[k, a])
                        {
                            length++;
                        }
                    }
                    if (length >= maxLength)
                    {
                        maxLength = length;
                    }
                    length = 0;
                    //4. Check bottom-left direction

                    for (int k = i, a = j; k < matrix.GetLength(0) && a > 0; k++, a--)
                    {
                        if (matrix[i, j] == matrix[k, a])
                        {
                            length++;
                        }
                    }
                    if (maxLength <= length)
                    {
                        maxLength = length;

                    }
                    length = 0;

                }

            }

            Console.WriteLine(maxLength);

        }

    }
}
