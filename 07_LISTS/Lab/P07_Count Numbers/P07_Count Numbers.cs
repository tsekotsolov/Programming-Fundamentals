using System;
using System.Linq;

namespace P07_Count_Numbers
{
    class Program
    {
        static void Main()
        {

            var numbers = Console.ReadLine()
         .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
         .Select(int.Parse)
         .ToList();

            numbers.Sort();

            int[] counterArray = new int[1001];

            for (int i = 0; i < numbers.Count; i++)
            {
                counterArray[numbers[i]]++;
            }

            for (int i = 0; i < counterArray.Length; i++)
            {
                if (counterArray[i] != 0)
                {
                    Console.WriteLine($"{i} -> {counterArray[i]}");
                }

            }
        }
    }
}
