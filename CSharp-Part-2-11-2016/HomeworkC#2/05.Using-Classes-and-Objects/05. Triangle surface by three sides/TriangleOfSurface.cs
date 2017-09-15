using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle_surface_by_three_sides
{
    class TriangleOfSurface
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}",TriangleSurface(sideA,sideB,sideC));

        }

        static double TriangleSurface(double A, double B, double C)
        {
            double result = 0;
            double semiperimeter = (A + B + C) * 0.5;
            result = Math.Sqrt(semiperimeter * (semiperimeter - A) * (semiperimeter - B) * (semiperimeter - C));

            return result;
        }
    }

}
