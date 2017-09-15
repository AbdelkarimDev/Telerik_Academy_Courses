using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.First_larger_than_neighbours
{
    class Program
    {
        static int LargerThanNeighbours(int[] numbers)
        {
            int value = 0;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    value = i;
                    return value;
                }
                else
                {
                    value = -1;

                }
            }
            return value;

        }

        static void Main(string[] args)
        {
            int leght = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(LargerThanNeighbours(numbers));


        }
    }
}
