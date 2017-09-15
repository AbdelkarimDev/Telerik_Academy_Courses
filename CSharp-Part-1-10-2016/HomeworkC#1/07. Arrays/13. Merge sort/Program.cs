using System;


namespace _07.Selection_sort
{
    class SelectionSort
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k] <= array[i])
                    {
                        temp = array[i];
                        array[i] = array[k];
                        array[k] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }


        }
    }
}
