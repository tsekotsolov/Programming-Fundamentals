using System;
using System.Linq;


namespace P10_Pairs_by_Difference
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int diff = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i]-array[j]==diff )
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}
