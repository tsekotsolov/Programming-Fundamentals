using System;

namespace _11.OddNumber
{
    class Program
    {
        static void Main()
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            while (n % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                n = Math.Abs(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"The number is: {n}");

        }
    }
}
