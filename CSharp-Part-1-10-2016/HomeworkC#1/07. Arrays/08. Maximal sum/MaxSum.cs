using System;


namespace _08.Maximal_sum
{
    class MaxSum
    {
        static void Main()

        {
            int N = int.Parse(Console.ReadLine());
            int[] array =new int[N];
            int sum = 0;
            int maxSum = int.MinValue;
            int start = 0;
            int end = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i; k < array.Length; k++)
                {
                    sum += array[k];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        start = i;
                        end = k;
                    }
                }
                sum = 0;
            }
            Console.WriteLine("{0}", maxSum);
            //for (int i = (int)start; i <= end; i++)
            //{
            //    Console.Write("{0} ", array[i]);
            //}




        }
    }
}
