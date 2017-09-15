using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Compare_arrays
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];
            int[] array2 = new int[N];
            for (int i = 0; i < N; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            bool a = true;

            for (int i = 0; i < N; i++)
            {
                if (array1[i] == array2[i])
                {
                    a = true;
                }
                else
                {
                    a = false;
                }

            }
            Console.WriteLine("{0}", a ? "Equal" : "Not equal");


            //Това проверява дали два масива са еднакви по опростено
            //Console.WriteLine("{0}", array1.SequenceEqual(array2) ? "Equal" : "Not equal");

        }
    }
}

