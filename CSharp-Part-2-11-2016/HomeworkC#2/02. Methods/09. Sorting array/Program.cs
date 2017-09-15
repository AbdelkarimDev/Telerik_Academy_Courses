using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_array
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            SortedArray(numbers);
            Console.WriteLine(string.Join(" ", SortedArray(numbers)));
        }

        static int[] SortedArray(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
            //descending order
            //Array.Reverse(numbers);
            //Array.Sort(numbers);
            //string output = string.Empty;

            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    output += numbers[index] + " ";
            //}

            //Console.WriteLine(output);
        }
    }
}
