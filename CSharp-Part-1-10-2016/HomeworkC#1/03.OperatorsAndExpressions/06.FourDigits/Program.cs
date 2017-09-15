using System;


namespace _06.FourDigits
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int a = number / 1000 % 10;
            int b = number / 100 % 10;
            int c = number / 10 % 10;
            int d = number % 10;
            int example = a + b + c + d;
            Console.WriteLine(example);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
