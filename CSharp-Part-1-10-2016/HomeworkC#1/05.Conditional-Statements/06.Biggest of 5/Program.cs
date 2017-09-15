using System;


namespace _06.Biggest_of_5
{
    class Program
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());
            double E = double.Parse(Console.ReadLine());
            bool equal = B == A && B == C && B == D && B == E;
            if (!(A >= B && A >= C && A >= D && A >= E) || !equal)
            {
                Console.WriteLine(A);
            }
            else if (!(B >= A && B >= C && B >= D && B >= E) || !equal)
            {
                Console.WriteLine(B);
            }
            else if (!(C > A && C > B && C > D && C > E)||!equal)
            {
                Console.WriteLine(C);
            }
            else if (!(D > A && D > B && D > C && D > E)||!equal)
            {
                Console.WriteLine(D);
            }
            else if (B == A && B == C && B == D && B == E)
            {
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine(E);
            }
        }
    }
}
