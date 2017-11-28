using System;
using System.Text.RegularExpressions;

namespace P03_Task3
{
    class P03_AnonymousVox
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var values = Console.ReadLine().Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"([A-Za-z]+)(.*)(\1)";

            var matches = Regex.Matches(text, pattern);

            var counter = 0;
            foreach (Match match in matches)
            {
                var replacment = match.Groups[1] + values[counter] + match.Groups[3];
                counter++;

                text = text.Replace(match.Value,replacment);
            }

            Console.WriteLine(text);

        }
    }
}
