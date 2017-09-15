using System;


namespace _04.MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            double FirstNumber = double.Parse(Console.ReadLine());
            double SecondNumber = double.Parse(Console.ReadLine());
            double ThirdNumber = double.Parse(Console.ReadLine());

            if (FirstNumber * SecondNumber * ThirdNumber < 0)
            {
                Console.WriteLine("-");
            }
            else if (FirstNumber * SecondNumber * ThirdNumber == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("+");
            }

        }
    }
}
