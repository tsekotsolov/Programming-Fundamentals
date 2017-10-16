using System;

namespace P02_CircleArea
{
    class P02_CircleArea
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine($"{area:f12}");

        }
    }
}
