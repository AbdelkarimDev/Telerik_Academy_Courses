using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.A.Fill_the_matrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char character = char.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int counter = 1;

            if (character == 'a')
            {


                for (int col = 0; col < matrix.GetLength(1); col++)
                {


                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }
            }
            if (character == 'b')
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            matrix[row, col] = counter;
                            counter++;
                        }
                    }
                    else
                    {
                        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                        {
                            matrix[row, col] = counter;
                            counter++;
                        }
                    }

                }
            }
            if (character == 'c')
            {
                int counter2 = n * n;

                for (int i = n - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {
                    }
                    int col = 0;
                    for (int row = i; row < n; row++)
                    {
                        matrix[row, col] = counter;
                        col++;
                        counter++;
                    }

                    if (i > 0) // Izbqgva povtornoto populvane na glavnia diagonal
                    {
                        col = n - 1;
                        for (int row = (n - 1) - i; row >= 0; row--)
                        {
                            matrix[row, col] = counter2;
                            col--;
                            counter2--;
                        }
                    }

                }


            }
            if (character == 'd')
            {
                for (int i = 0; i <= n / 2; i++)
                {
                    //move down
                    for (int c = i; c <= n - 1 - i; c++)
                    {
                        matrix[c, i] += counter;
                        counter++;
                    }
                    //move right
                    for (int k = i + 1; k < n - i; k++)
                    {
                        matrix[n - 1 - i, k] = counter;
                        counter++;
                    }
                    //move up
                    for (int j = n - 1 - 1 - i; j >= 0 + i; j--)
                    {
                        matrix[j, n - 1 - i] = counter;
                        counter++;
                    }
                    //move left
                    for (int p = n - 1 - 1 - i; p >= i + 1; p--)
                    {
                        matrix[i, p] = counter;
                        counter++;
                    }
                }
            }
            //Printing Console
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == (n - 1)) //last element without spacing 
                    {
                        Console.Write(matrix[row, col]);
                    }
                    else //any other element, separated with spacing
                    {
                        Console.Write(matrix[row, col] + " ");
                    }

                }
                Console.WriteLine();
            }

        }
    }
}
