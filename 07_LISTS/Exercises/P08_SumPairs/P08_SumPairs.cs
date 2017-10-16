using System;
using System.Collections.Generic;
using System.Linq;


namespace P08_SumPairs
{
    class P08_SumPairs
    {
        static void Main(string[] args)
        {

            var inputLine = Console.ReadLine()
         .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
         .Select(long.Parse)
         .ToList(); 

            List<long> sumedList = new List<long>();
            for (int i = 0; i < inputLine.Count - 1; i += 2)
            {
                sumedList.Add(inputLine[i] + inputLine[i + 1]);
            }

            if (inputLine.Count % 2 == 1)
            {
                sumedList.Add(inputLine[inputLine.Count - 1]);
            }
            
            Console.WriteLine(string.Join(", ",sumedList));
        }
    }
}
