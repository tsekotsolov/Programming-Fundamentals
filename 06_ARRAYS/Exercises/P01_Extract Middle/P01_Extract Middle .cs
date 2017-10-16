using System;
using System.Linq;


namespace P01_Extract_Middle
{
    class Program
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secondArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int lenght = Math.Min(firstArray.Length, secondArray.Length);

            int rightCommonEnd = 0;
            int leftCommonEnd = 0;

            for (int i = 0; i < lenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    leftCommonEnd++;
                }

                if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                    rightCommonEnd++;
            }

            Console.WriteLine(Math.Max(rightCommonEnd,leftCommonEnd));

        }

    }
    }
