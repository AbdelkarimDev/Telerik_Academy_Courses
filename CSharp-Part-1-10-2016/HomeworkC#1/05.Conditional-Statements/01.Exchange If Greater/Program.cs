using System;


namespace _01.Exchange_If_Greater
{
    class Program
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            if (A >= B)
            {
                double temp;
                temp = A;
                A = B;
                B = temp;
            }

            Console.WriteLine("{0} {1}", A, B);

        }
    }
}
