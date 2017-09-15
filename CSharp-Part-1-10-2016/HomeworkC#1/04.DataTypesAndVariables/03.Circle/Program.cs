using System;


namespace _03.Circle
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            if (r > 0)
            {
                Console.WriteLine("{0:F2} {1:F2}", 2 * Math.PI * r, Math.PI * r * r);
            }
        }
    }
}
