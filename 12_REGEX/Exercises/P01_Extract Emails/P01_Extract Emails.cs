using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01_Extract_Emails
{
    class P01_Extract_Emails
    {
        static void Main()
        {
            var input = Console.ReadLine();

            string pattern = @"(?<=\s)[A-Za-z0-9]+[-_\.]?([A-Za-z0-9]+)+@[A-Za-z-]+(\.[A-Za-z]+)+";

            var validEmails = Regex.Matches(input, pattern);


            foreach (Match mail in validEmails)
            {

                Console.WriteLine(mail.Value);

            }
        }
    }
}
