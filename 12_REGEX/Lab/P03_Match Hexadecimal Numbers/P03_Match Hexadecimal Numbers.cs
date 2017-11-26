using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P03_Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            var matches = Regex.Matches(input, pattern).Cast<Match>().Select(a => a.Value).ToList();


            Console.WriteLine(string.Join(" ", matches));


        }
        
    }
}
