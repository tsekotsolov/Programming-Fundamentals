using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02_WormIpsum
{
    class P02_WormIpsum
    {
        static void Main()
        {
            var input = Console.ReadLine();


            while (input != "Worm Ipsum")
            {
                bool isValid = ChecksValidity(input);

                if (isValid)
                {
                    var words = Regex.Split(input, "\\W").Where(w => w != "").ToList();

                    var newWord = string.Empty;

                    foreach (var word in words)
                    {
                        var listOfChars = new Dictionary<char, int>();

                        foreach (var letter in word)
                        {
                            if (!listOfChars.ContainsKey(letter))
                            {
                                listOfChars.Add(letter, 1);
                            }

                            else
                            {
                                listOfChars[letter]++;
                            }
                        }

                        var mostCommonLetterOccurance = listOfChars.Values.Max();
                        var mostCommonLetter = listOfChars.FirstOrDefault(x => x.Value == mostCommonLetterOccurance).Key;

                        if (mostCommonLetterOccurance > 1)
                        {
                            newWord = new string(mostCommonLetter, word.Length);
                            input = input.Replace(word, newWord);
                        }
                    }

                    Console.WriteLine(input);
                }

                input = Console.ReadLine();

            }
        }

        private static bool ChecksValidity(string input)
        {
            string pattern = @"\.";
            var match = Regex.Matches(input, pattern);
            bool isValid = false;

            if (match.Count==1)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
