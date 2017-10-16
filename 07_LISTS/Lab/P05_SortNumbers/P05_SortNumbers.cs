using System;
using System.Linq;

namespace P05_SortNumbers
{
    class P05_SortNumbers
    {
        static void Main(string[] args)
        {

            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            nums.Sort();

            Console.WriteLine(String.Join(" <= ", nums));

        }
    }
}
