using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int midEl = 0;
            bool found = false;
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int X = int.Parse(Console.ReadLine());
            int L = 0;
            int R = N - 1;

            while (L <= R && found != true)
            {
                midEl = (L + R) / 2;
                if (X == arr[midEl])
                {
                    found = true;
                }
                else if (X > arr[midEl])
                {
                    L = midEl + 1;
                }
                else if (X < arr[midEl])
                {
                    R = midEl - 1;
                }
            }

            if (!found)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(midEl);
            }
        }
    }
}