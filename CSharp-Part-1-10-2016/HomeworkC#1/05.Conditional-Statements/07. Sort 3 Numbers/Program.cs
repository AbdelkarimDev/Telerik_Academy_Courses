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
            if (NumberA >= NumberB && NumberA >= NumberC)
            {
                if (NumberC >= NumberB)
                {
                    Console.WriteLine("{0} {2} {1}", NumberA, NumberB, NumberC);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", NumberA, NumberB, NumberC);
                }
            }

            else if (NumberB > NumberA && NumberB >= NumberC)
            {
                if (NumberA > NumberC)
                {
                    Console.WriteLine("{1} {0} {2}", NumberA, NumberB, NumberC);
                }
                else
                {
                    Console.WriteLine("{1} {2} {0}", NumberA, NumberB, NumberC);
                }
            }
            else if (NumberC > NumberB && NumberC > NumberA)
            {
                if (NumberA >= NumberB)
                {
                    Console.WriteLine("{2} {0} {1}", NumberA, NumberB, NumberC);
                }
                else
                {
                    Console.WriteLine("{2} {1} {0}", NumberA, NumberB, NumberC);
                }

            }
        }
    }

}