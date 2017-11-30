using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace P03_Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();
            var fullpatern = @"(\D+)(\d+)";


            var match = Regex.Matches(input, fullpatern);
            var digitList = new List<int>();
            var symbolList = new List<string>();

            foreach (Match item in match)
            {
                symbolList.Add(item.Groups[1].ToString());

                digitList.Add(int.Parse(item.Groups[2].ToString()));
            }


            var bag = new StringBuilder();

            for (int i = 0; i < digitList.Count; i++)
            {
                for (int j = 0; j < digitList[i]; j++)
                {
                    bag.Append(symbolList[i]);
                }
            }

            var uniqueList = new List<char>();

            foreach (var ch in bag.ToString())
            {
                if (!uniqueList.Contains(ch))
                {
                    uniqueList.Add(ch);
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueList.Count}");
            Console.WriteLine(bag);

        }
    }
}
