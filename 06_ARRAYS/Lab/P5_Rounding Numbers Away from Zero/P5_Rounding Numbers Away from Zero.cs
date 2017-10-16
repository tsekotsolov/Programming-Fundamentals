using System;
using System.Linq;


namespace P5_Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main()
        {
            double[] array = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} => {Math.Round(array[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
