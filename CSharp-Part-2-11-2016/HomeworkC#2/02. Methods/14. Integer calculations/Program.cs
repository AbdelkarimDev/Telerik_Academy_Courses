using System;
using System.Linq;
using System.Numerics;
namespace _14.Integer_calculations
{
    class Program
    {
        static void ActionsWithIntegers(params int[] elements)
        {
            double sum = 0;
            int minValue = elements[0];
            int maxValue = elements[0];
             BigInteger product = 1;
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
                product *= elements[i];

                if (minValue >= elements[i])
                {
                    minValue = elements[i];
                }
                if (maxValue <= elements[i])
                {
                    maxValue = elements[i];
                }

            }
            Console.WriteLine("{0}", minValue);
            Console.WriteLine("{0}", maxValue);
            Console.WriteLine("{0:f2}", sum / elements.Length);
            Console.WriteLine("{0}", sum);
            Console.WriteLine("{0}", product);
        }


        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            ActionsWithIntegers(elements);


        }


    }
}
