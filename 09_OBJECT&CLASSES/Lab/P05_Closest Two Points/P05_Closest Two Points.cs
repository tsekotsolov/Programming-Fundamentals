using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Closest_Two_Points
{
    class Program
    {

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                Point p = ReadPoint();
                points.Add(p);
            }

            double minDistance = double.MaxValue;
            Point closest1 = null;
            Point closest2 = null;


            for (int i = 0; i < points.Count; i++)
            {
                for (int j = 0; j < points.Count; j++)
                {
                    if (i != j)
                    {
                        double currentDistance = CalcDistance(points[i], points[j]);
                        if (currentDistance < minDistance)
                        {
                            minDistance = currentDistance;
                            closest1 = points[i];
                            closest2 = points[j];
                        }
                    }

                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({closest1.X }, {closest1.Y})");
            Console.WriteLine($"({closest2.X }, {closest2.Y})");

        }

        static Point ReadPoint()

        {
            int[] pointInfo = Console.ReadLine().Split()
            .Select(int.Parse).ToArray();

            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}

