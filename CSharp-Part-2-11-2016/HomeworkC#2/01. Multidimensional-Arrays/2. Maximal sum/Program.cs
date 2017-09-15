using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Maximal_sum
{
    class Program
    {
        static void Main()
        {
            
            string[] inputdata = Console.ReadLine().Split(' ');  // int[] lenght = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                                                                  

            int rows = int.Parse(inputdata[0]);
            int cols = int.Parse(inputdata[1]);

            int[,] matrix = new int[rows,cols];                   ////int[,] matrix = new int[lenght[0], lenght[1]]
            int width = 3;
            int hight = 3;

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            // Find the maximal sum platform of size hight x width
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - hight + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - width + 1; col++)
                {
                    int sum = 0;
                    for (int platformrow = row; platformrow < row + hight; platformrow++)
                    {
                        for (int platformcol = col; platformcol < col + width; platformcol++)
                        {
                            sum += matrix[platformrow, platformcol];
                        }

                    }
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            //print result
            //for (int platformrow = bestRow; platformrow < bestRow + hight; platformrow++)
            //{
            //    for (int platformcol = bestCol; platformcol < bestCol + width; platformcol++)
            //    {
            //        Console.Write("{0} ", matrix[platformrow, platformcol]);
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine("{0}", bestSum);

        }
    }
}
