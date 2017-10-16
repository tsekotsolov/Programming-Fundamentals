﻿using System;

namespace P12_Rectangle_Properties
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = (width + height) * 2;
            double area = width * height;
            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));

            Console.WriteLine($"{perimeter}{Environment.NewLine}" +
                $"{area}{Environment.NewLine}" +
                $"{diagonal}{Environment.NewLine}");
        }
    }
}
