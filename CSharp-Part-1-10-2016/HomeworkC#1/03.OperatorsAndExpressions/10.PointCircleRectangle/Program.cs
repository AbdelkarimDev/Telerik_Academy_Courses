using System;

//Write a program that reads a pair of coordinates x and y and uses an expression to checks for 
//given point(x, y) if it is within the circle K({ 1, 1}, 1.5) and out of the rectangle
//    R(top= 1, left= -1, width= 6, height= 2)

namespace _10.PointCircleRectangle
{
    class Program
    {
        static void Main()
        {
            double circleX = 1;
            double circleY = 1;
            double circleradius = 1.5;
            double rectangleTop = 1;
            double rectangleLeft = -1;
            double rectangleWidth = 6;
            double rectangelHeight = 2;
            double rectangleDown = rectangleTop - rectangelHeight;
            double rectangleRight = rectangleLeft + rectangleWidth;
            double coordinateX = double.Parse(Console.ReadLine());
            double coordinateY = double.Parse(Console.ReadLine());
            bool ispointincircle = circleradius * circleradius >= ((coordinateX - circleX) * (coordinateX - circleX) + (coordinateY - circleY) * (coordinateY - circleX));
            bool ispoinrectangle = (rectangleLeft <= coordinateX && coordinateX <= rectangleRight) && (rectangleDown <= coordinateY && coordinateY <= rectangleTop);
            Console.WriteLine("{0} {1}", ispointincircle, ispoinrectangle);
            if (ispointincircle)
            {
                if (ispoinrectangle)
                {
                    Console.WriteLine("inside circle inside rectangle");
                }
                else
                {
                    Console.WriteLine("inside circle outside rectangle");
                }
            }
            else
            {
                if (ispoinrectangle)
                {
                    Console.WriteLine("outside circle inside rectangle");

                }
                else
                {
                    Console.WriteLine("outside circle outside rectangle");
                }

            }
        }
    }
}
