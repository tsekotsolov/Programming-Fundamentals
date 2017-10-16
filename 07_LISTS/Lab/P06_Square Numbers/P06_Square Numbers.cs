using System;
using System.Collections.Generic;
using System.Linq;


namespace P06_Square_Numbers
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
             .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList();

            List<int> squares = new List<int>();


            for (int i = 0; i < nums.Count; i++)
            {
                if (Math.Sqrt(nums[i]) == Math.Truncate(Math.Sqrt(nums[i])))
                {
                    squares.Add(nums[i]);
                }

            }
            squares.Sort();
            squares.Reverse();

            Console.WriteLine(String.Join(" ", squares));



            

           

        }
    }
}
