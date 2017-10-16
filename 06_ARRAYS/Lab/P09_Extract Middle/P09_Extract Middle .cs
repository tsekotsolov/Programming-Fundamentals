using System;
using System.Linq;


namespace P09_Extract_Middle
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var resultArray = new int[3];
        

            if (inputArray.Length % 2 == 0)
            {
              resultArray = inputArray.Skip(inputArray.Length / 2 - 1).ToArray();
              resultArray = resultArray.Take(2).ToArray();
            }

            else
            {
               resultArray = inputArray.Skip(inputArray.Length / 2 - 1).ToArray();
               resultArray = resultArray.Take(3).ToArray();
            }
            
            Console.WriteLine(string.Join(" ", resultArray));

        }
    }
}
