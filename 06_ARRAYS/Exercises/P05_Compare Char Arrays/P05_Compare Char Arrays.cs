using System;
using System.Linq;


namespace P05_Compare_Char_Arrays
{
    class Program
    {
        static void Main()
        {
           char[] firstArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            char[] secondArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

           
            var minLenght = Math.Min(firstArray.Length,secondArray.Length);

            int countEqual = 0;
            int countFitstPrinted = 0;
            int countSecondPrinted = 0;

            for (int i = 0; i < minLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    countEqual++;
                    break;
                }

                else if (firstArray[i] < secondArray[i])
                {
                    countFitstPrinted++;
                    break;
                }

                else
                {
                    countSecondPrinted++;
                    break;
                }
            }

            if (countEqual == minLenght && firstArray.Length==secondArray.Length)
            {
                Console.WriteLine($"{string.Join("",firstArray)}{Environment.NewLine}{string.Join("", secondArray)} ");
            }

            else if (countFitstPrinted>countSecondPrinted)
            {
                Console.WriteLine($"{string.Join("", firstArray)}{Environment.NewLine}{string.Join("", secondArray)} ");
            }

            else if (firstArray.Length< secondArray.Length)
            {
                Console.WriteLine($"{string.Join("", firstArray)}{Environment.NewLine}{string.Join("", secondArray)} ");
            }

            else
            {
                Console.WriteLine($"{string.Join("", secondArray)}{Environment.NewLine}{string.Join("", firstArray)} ");
            }
        }
    }
}
