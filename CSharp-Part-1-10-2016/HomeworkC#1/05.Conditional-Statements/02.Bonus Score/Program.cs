using System;

namespace _02.Bonus_Score
{
    class Program
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            switch (A)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(A * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(A * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(A * 1000);
                    break;
                default:
                    Console.WriteLine("invalid score");
                    break;
            }
        }
    }
}

