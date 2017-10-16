using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Split_by_Word_Casing
{
    class Program
    {
        static void Main()
        {

            var inputLine = Console.ReadLine()
         .Split(new[] { ' ', ',',';',':','.','!','(',')','"','\'','\\','/','[',']' }, StringSplitOptions.RemoveEmptyEntries)
         .ToList();


            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();


            foreach (var word in inputLine)
            {

                bool hasLowerCase = word.All(x => char.IsLower(x)); // determines if the word contains only LowerCases
                bool hasOnlyUpperCase = word.All(x => char.IsUpper(x));  // determines if the word contains only Uppercases
                bool isANumber = word.All(x => char.IsDigit(x));


                if (hasLowerCase && !isANumber)
                {

                    lowerCase.Add(word);

                }

                else if (hasOnlyUpperCase && !isANumber)
                {
                    upperCase.Add(word);
                }

                else
                {
                    mixedCase.Add(word);
                }

            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
