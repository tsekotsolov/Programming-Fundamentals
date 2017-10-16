using System;


namespace P08_Center_Point
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            string result = FindsClosestPointFromZero(x1, y1, x2, y2);
            Console.WriteLine(result);
        }

        static string FindsClosestPointFromZero(double x1, double y1, double x2, double y2)
        {
            double line1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double line2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (line1>line2)
            {
               return ($"({x2}, {y2})");
            }
            else
            {
                return($"({x1}, {y1})");
            }

        }
    }
    
}
