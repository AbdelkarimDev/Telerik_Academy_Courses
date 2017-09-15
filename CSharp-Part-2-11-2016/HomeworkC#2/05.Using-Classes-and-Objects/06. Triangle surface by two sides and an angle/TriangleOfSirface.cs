using System;

namespace _06.Triangle_surface_by_two_sides_and_an_angle
{
    class TriangleOfSirface
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angleDegrees = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", TriangleSurface(sideA, sideB, angleDegrees));

        }

        static double TriangleSurface(double A, double B, double angleDegrees)     
        {
            double result = 0;
            double angleRadians = angleDegrees * Math.PI / 180;
            result = 0.5*A*B*Math.Sin(angleRadians);

            return result;
        }
    }
}
