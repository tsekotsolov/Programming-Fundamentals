using System;
using System.Linq;

namespace P07_Sum_Arrays
{
    class Program
    {
        static void Main()
        {
            int[] firstArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] resultArray = new int[Math.Max(firstArray.Length, secondArray.Length)];

            if (firstArray.Length>=secondArray.Length)
            {
                for (int i = 0; i < resultArray.Length; i++)
                {
                    resultArray[i] = secondArray[i % secondArray.Length];
                }

                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write($"{resultArray[i] + firstArray[i]} ");
                }
                Console.WriteLine();

            }

            else
            {
                for (int i = 0; i < resultArray.Length; i++)
                {
                    resultArray[i] = firstArray[i % firstArray.Length];
                }

                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write($"{resultArray[i] + secondArray[i]} ");
                }
                Console.WriteLine();

            }

        }
    }
}
