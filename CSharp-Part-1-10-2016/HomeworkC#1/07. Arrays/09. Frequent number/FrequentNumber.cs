using System;


namespace _09.Frequent_number
{
    class FrequentNumber
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int digit = 0;
            int countdigit ;
            int maxcountdigit = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                countdigit = 0;

                for (int k = i; k < array.Length; k++)
                {
                    if (array[k] == array[i])
                    {
                        countdigit++;

                        if (countdigit > maxcountdigit)
                        {
                            maxcountdigit = countdigit;
                            digit = i;
                            
                        }
                    }


                }

            }

            Console.WriteLine("{0} ({1} times)",array[digit],maxcountdigit);


        }
    }
}
