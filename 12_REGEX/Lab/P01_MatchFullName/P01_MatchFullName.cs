using System;
using System.Text.RegularExpressions;

namespace P01_MatchFullName
{
    class P01_MatchFullName
    {
        static void Main()
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            var text = Console.ReadLine();

            MatchCollection names = Regex.Matches(text, pattern);

            foreach (Match name in names)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
