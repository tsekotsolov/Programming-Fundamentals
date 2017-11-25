using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace P02_Match_Phone_Number
{
    class Program
    {
        static void Main()
        {

            string phoneString = Console.ReadLine();

            var pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";

            List<string> phoneList = new List<string>();

            var matches = Regex.Matches(phoneString, pattern);

            foreach (Match item in matches)
            {
                phoneList.Add(item.Value);
            }

            Console.WriteLine(string.Join(", ", phoneList)); 

        }
    }
}
