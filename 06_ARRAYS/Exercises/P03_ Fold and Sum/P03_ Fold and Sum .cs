using System;
using System.Linq;


namespace P03__Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k =  inputArray.Length/4;

            int[] leftArray = inputArray.Take(k).ToArray();
            int[] middleArray = inputArray.Skip(k).Take(2 * k).ToArray();
            int[] rightArray = inputArray.Skip(3 * k).Take(2 * k).ToArray();


            int[] mergedArray = leftArray.Reverse().Concat(rightArray.Reverse()).ToArray();

            int[] sumArray = new int[2 * k];

            for (int i = 0; i < 2*k; i++)
            {
                sumArray[i] = mergedArray[i] + middleArray[i];
            }

            Console.WriteLine(String.Join(" ", sumArray));

        }
    }
}
