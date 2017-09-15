using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class Program
    {
        static void ApperanceCount(int[] numbers,int x)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == x)
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("{0}",counter);
            }
        }

        static void Main(string[] args)
        {
            int leght = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());
            ApperanceCount(numbers, x);


        }

    }
}
