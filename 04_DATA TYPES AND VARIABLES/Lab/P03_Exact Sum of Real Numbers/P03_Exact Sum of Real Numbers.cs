﻿using System;

namespace P03_Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal sum =0;

            for (int i = 0; i < n; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                sum += currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
