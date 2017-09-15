using System;


namespace _02.GravitationOnTheMoon
{
    class Program
    {
        static void Main()
        {
            double weight = double.Parse(Console.ReadLine());
            double WeightOfMoon = 17.0 / 100 * weight;
            Console.WriteLine("{0:0.000}",WeightOfMoon);
                
        }
    }
}
