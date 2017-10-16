using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {

            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();


            var counts = new SortedDictionary<double, int>();


            foreach (var num in nums)


                if (counts.ContainsKey(num))

                {
                    counts[num]++;
                }

                else
                {
                    counts[num] = 1;
                }

            foreach (var num in counts.Keys)

            {
                Console.WriteLine($"{num} -> {counts[num]}");
            }
        }
    }
}
