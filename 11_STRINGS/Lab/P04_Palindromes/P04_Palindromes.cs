using System;
using System.Collections.Generic;
using System.Text;


namespace P04_Palindromes
{
    class P04_Palindromes
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '.', '?', '!', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var palindromeDict = new SortedDictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                var isPalindrome = ChecksPalindrome(input[i]);

                if (isPalindrome)
                {
                    if (!palindromeDict.ContainsKey(input[i]))
                    {
                        palindromeDict.Add(input[i], i);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", palindromeDict.Keys));
        }

        private static bool ChecksPalindrome(string input)
        {
            var isPalindrome = false;
            var reversedBag = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                reversedBag.Append(input[input.Length - i - 1]);
            }

            var reversedString = reversedBag.ToString();


            if (reversedString == input)
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}
