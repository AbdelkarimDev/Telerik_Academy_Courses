using System;
//Write a program that reads a number N and prints on the console the first 
// N members of the Fibonacci sequence(at a single line, separated by 
// comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
namespace _10.Fibonacci_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long temp;
            long firstNumber = 0;
            long secondNumber = 1;

            Console.Write(firstNumber);
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(", {0}", secondNumber);
                temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber += temp;
            }
        }
    }
}