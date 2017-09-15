using System;


namespace _09.Sum_of_n_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            double sum = 0;
            while (num <= n)
            {
                double c = double.Parse(Console.ReadLine());
                num++;
                sum += c;
            }
            Console.WriteLine(sum);
        }
    }
}
