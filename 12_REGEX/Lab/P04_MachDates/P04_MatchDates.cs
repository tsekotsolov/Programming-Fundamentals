using System;
using System.Text.RegularExpressions;

namespace P04_MachDates
{
    class P04_MatchDates
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            var stringOfDates =Console.ReadLine();

            var validDates = Regex.Matches(stringOfDates, pattern);

            foreach (Match date in validDates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            }


        }
    }
}
