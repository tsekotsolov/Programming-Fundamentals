using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Intersection_of_Circles
{
    class Program
    {

        class Point
        {
            public double X;
            public double Y;
        }

        class Circle
        {
           
            public double Radius;

        }
        static void Main()
        {

            var inputFirstCircle = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToArray();

            var inputSecondCircle = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToArray();

            Point centerFirstCircle = ReadPoint(inputFirstCircle);
            Point centerSecondCircle = ReadPoint(inputSecondCircle);
            Circle radiusFirstCircle = ReadRadius(inputFirstCircle);
            Circle radiusSecondCircle = ReadRadius(inputSecondCircle);

            var distanceBetweenCenters = FindDistanceBetweenCenters(centerFirstCircle,centerSecondCircle);

            if (distanceBetweenCenters<=radiusFirstCircle.Radius+radiusSecondCircle.Radius)
            {
                Console.WriteLine("Yes");
            }

            else if (distanceBetweenCenters > radiusFirstCircle.Radius + radiusSecondCircle.Radius)
            {
                Console.WriteLine("No");
            }

        }

        private static Circle ReadRadius(double[]input)
        {
            Circle radius = new Circle();
            radius.Radius = input[2];
            return radius;
        }

        private static double FindDistanceBetweenCenters(Point firstPoint, Point secondPoint)
        {
            var distanceSquared = firstPoint.X*firstPoint.X + secondPoint.Y*secondPoint.Y;
            return Math.Sqrt(distanceSquared);
        }

        private static Point ReadPoint(double[] input)
        {
           
            Point center = new Point();
            center.X = input[0];
            center.Y = input[1];
            return center;
        }
    }
}
