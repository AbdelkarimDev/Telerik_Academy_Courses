using System;


namespace _04.Triangle_surface_by_side_and_altitude
{
    class TrianglesSurfaces
    {
        static void Main()
        {

            double sideA = double.Parse(Console.ReadLine());
            double attribute = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}",(TriangleSurface(sideA,attribute)));
        }

        static double TriangleSurface(double sideA,double attribute)
        {
            double result = 0;
            result = 0.5 * sideA * attribute;
                return result;
        }
    }

}
