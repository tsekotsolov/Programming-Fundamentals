using System;


namespace P06_Calculate_Triangle_Area
{
    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = CalculateTriangleArea(side, height);
            Console.WriteLine(area);

        }

        static double CalculateTriangleArea(double side, double height)
        {
            return side * height / 2;
        }
    }
}
