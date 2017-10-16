using System;
using System.Linq;

namespace P08_Most_Frequent_Number
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int frequentNumber = 0;
            int maxApearances = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;

                        if (count > maxApearances)
                        {
                            maxApearances = count;
                            frequentNumber = array[j];
                        }
                    }
                    //Console.WriteLine($"{array[i]} occurs {count} times");
                }
            }
            Console.WriteLine(frequentNumber);
        }
    }
}
