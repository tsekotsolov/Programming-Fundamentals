using System;

namespace _02.RectangleArea
{
    class rectangleArea
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = a * b;

            Console.WriteLine($"{area:f2}");

        }
    }
}
