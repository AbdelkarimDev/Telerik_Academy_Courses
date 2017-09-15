using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //Declare new array with bool values all TRUE!
            bool[] boolArray = new bool[N + 1];
            for (int i = 0; i < boolArray.Length; i++)
            {
                boolArray[i] = true;
            }

            for (int i = 2; i < Math.Sqrt(boolArray.Length); i++)
            {
                if (boolArray[i])
                {
                    for (int j = i * i; j < boolArray.Length; j = j + i)
                    {
                        boolArray[j] = false;
                    }
                }
            }

            for (int i = boolArray.Length - 1; i >= 0; i--)
            {
                if (boolArray[i] == true)
                {
                    Console.WriteLine("{0}", i);
                    break;
                }
            }
        }
    }
}