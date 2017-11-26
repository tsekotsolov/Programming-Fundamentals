using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P05_MatchNumbers
{
    class P05_MatchNumbers
    {
        static void Main()
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            var listOfNumbers = new List<string>();

            foreach (Match number in matches)
            {
                listOfNumbers.Add(number.Value);
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));

        }
    }
}
