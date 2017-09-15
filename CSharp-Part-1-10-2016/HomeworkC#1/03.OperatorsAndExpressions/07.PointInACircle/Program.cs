using System;


namespace _07.PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleX = 0;
            double circleY = 0;
            double circleradius = 2;
            double coordinateX = double.Parse(Console.ReadLine());
            double coordinateY = double.Parse(Console.ReadLine());
            double point = Math.Sqrt((coordinateX - circleX) * (coordinateX - circleX) + (coordinateY - circleY) * (coordinateY - circleX));
            if (coordinateX * coordinateX + coordinateY * coordinateY <= circleradius * circleradius)

            {
                Console.WriteLine("yes {0:0.00}", point);

            }
            else
            {
                Console.WriteLine("no {0:0.00}", point);
            }
        }
    }
}
