using System;
using System.Collections.Generic;
using System.Linq;


namespace P01_Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main()
        {

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var positives = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > 0)
                {
                    positives.Add(nums[i]);
                }
            }

            positives.Reverse();

            if (positives.Count==0)
            {
                Console.WriteLine("empty");
            }

            Console.WriteLine(String.Join(" ", positives));
        }
    }
}
