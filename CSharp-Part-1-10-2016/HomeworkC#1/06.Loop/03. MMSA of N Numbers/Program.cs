using System;


namespace _03.MMSA_of_N_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            double number;


            for (int i = 0; i < n; i++)
            {
                number = double.Parse(Console.ReadLine());

                sum += number;
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            double avg = (double)sum / (double)n;
            Console.WriteLine("min={0:F2}\nmax={1:F2}\nsum={2:F2}\navg={3:F2}", min, max, sum, avg);
        }
    }
}

