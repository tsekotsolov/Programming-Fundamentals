using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Search_for_a_Number
{
    class Program
    {
        static void Main()
        {

          var listOfIntegers = Console.ReadLine()
         .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
         .Select(int.Parse)
         .ToList();

            int[] array = Console.ReadLine()
                   .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

            var modifiedList = new List<int>();

            for (int i = 0; i < array[0]; i++)
            {
                modifiedList.Add(listOfIntegers[i]);
            }

            modifiedList.RemoveRange(0,array[1]);

            if (modifiedList.Contains(array[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
