using System;
using System.Text.RegularExpressions;

namespace P03_RegexMon
{
    class P03_RegexMon
    {
        static void Main()
        {

            var input = Console.ReadLine();

            var bojomanMatches = @"([A-Za-z]+)-([A-Za-z]+)";
            var didmonMatches = @"[^A-Za-z-\n]+";

            while (true)
            {

                var didiString = Regex.Match(input, didmonMatches).ToString();


                if (didiString != string.Empty)
                {
                    Console.WriteLine(didiString);
                    input = GetSubstring(input, didiString);

                    var bojoString = Regex.Match(input, bojomanMatches).ToString();

                    if (bojoString != string.Empty)
                    {
                        Console.WriteLine(bojoString);
                        input = GetSubstring(input, bojoString);
                    }
                }

                else
                {
                    break;
                }
            }
        }

        private static string GetSubstring(string input, string matchedString)
        {
            var didiStringPosition = input.IndexOf(matchedString);
            var didiStringLenght = matchedString.Length;
            var didiCutsFrom = didiStringPosition + didiStringLenght;
            input = input.Substring(didiCutsFrom);
            return input;
        }
    }
}
