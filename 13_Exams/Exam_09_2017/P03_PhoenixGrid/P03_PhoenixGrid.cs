using System;
using System.Linq;
using System.Text;

namespace P03_PhoenixGrid
{
    class P03_PhoenixGrid
    {
        static void Main()
        {
            var input = Console.ReadLine();

            while (input!= "ReadMe")
            {
                var currentString = input.Split('.');

                bool isValidMessage = ChecksValidity(currentString);
                bool isPalindrome = ChecksPalindrome(input);

                if (isValidMessage&&isPalindrome)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

                input = Console.ReadLine();

            }

        }


        private static bool ChecksValidity(string[] currentString)
        {
            var isValidMessage = true;


            for (int i = 0; i < currentString.Length; i++)
            {
                bool isValidPhrase = currentString[i].Length == 3 && !currentString[i].Contains('_') && !currentString[i].Contains(' ') && !currentString[i].Contains('\t');
                if (!isValidPhrase)
                {
                    isValidMessage = false;
                }

            }

            return isValidMessage;
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
