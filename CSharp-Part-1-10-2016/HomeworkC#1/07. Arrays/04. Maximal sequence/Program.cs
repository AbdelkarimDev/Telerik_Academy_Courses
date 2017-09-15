using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arroy = new int[N];
            int sequence = 1;
            int maxsequence = 1;

            for (int i = 0; i < arroy.Length; i++)
            {
                arroy[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < arroy.Length - 1; i++)
            {
                if (arroy[i] == arroy[i + 1])
                {
                    sequence++;
                }
                else
                {
                    sequence = 1;
                }
                if (sequence > maxsequence)
                {
                    maxsequence++;
                }
            }
            Console.WriteLine(maxsequence);

        }
    }
}
