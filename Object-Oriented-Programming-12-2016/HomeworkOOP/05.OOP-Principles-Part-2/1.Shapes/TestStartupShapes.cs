using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class TestStartupShapes
    {
        static void Main()
        {
            Shape[] allShapes = { new Rectangle(4.5, 6.7), new Triangle(3.4, 3.9), new Square(4) };



            foreach (Shape shp in allShapes)
            {
                Console.WriteLine("{0} surface: {1:f2}", shp.GetType().Name, shp.CalculateSurface());
            }
        }
    }
}