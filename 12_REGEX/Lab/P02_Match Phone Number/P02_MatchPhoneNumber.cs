using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace P02_Match_Phone_Number
{
    class Program
    {
        static void Main()
        {
            string pattern = @"^\+359(\s|-)2\1\d{3}\1\d{4}\b$";

            var phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, pattern);

        }
    }
}
