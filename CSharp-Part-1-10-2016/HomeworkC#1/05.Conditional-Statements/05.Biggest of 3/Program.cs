using System;

namespace _05.Biggest_of_3
{
    class Program
    {
        static void Main()
        {
            double NumberA = double.Parse(Console.ReadLine());
            double NumberB = double.Parse(Console.ReadLine());
            double NumberC = double.Parse(Console.ReadLine());
            if ((NumberA > NumberB && NumberB > NumberC) || (NumberA > NumberC && NumberC > NumberB))
            {
                Console.WriteLine(NumberA);
            }
            else if ((NumberC > NumberB && NumberC > NumberA) || (NumberC > NumberA && NumberA > NumberB))
            {
                Console.WriteLine(NumberC);
            }
            else if (NumberA == NumberB && NumberB == NumberC)
            {
                Console.WriteLine(NumberA);
            }
            else
            {
                Console.WriteLine(NumberB);
            }
        }
    }
}
