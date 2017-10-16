using System;


namespace P11_Geometry_Calculator
{
    class Program
    {
        static void Main()
        {
            string figure = Console.ReadLine();

            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine($"{FindTriangleArea(side,height):f2}");
            }

            else if (figure=="square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{FindSquareArea(side):f2}");
            }

            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine($"{FindTRectangleArea(width, height):f2}");

            }

            else if (figure=="circle")
            {
                double radius = double.Parse(Console.ReadLine());

                Console.WriteLine($"{FindCircleArea(radius):f2}");
            }
        }

        private static double FindCircleArea(double radius)
        {
            double circleArea = Math.PI * radius*radius ;
            return circleArea;
        }

        private static double FindTRectangleArea(double width, double height)
        {
            double rectangleArea = width*height;
            return rectangleArea;
        }

        private static double FindSquareArea(double side)
        {
            double squareArea = side*side;
            return squareArea;
        }

        private static double FindTriangleArea(double side, double height)
        {
            double triangleArea = side*height/ 2;
            return triangleArea;
        }
    }
}
