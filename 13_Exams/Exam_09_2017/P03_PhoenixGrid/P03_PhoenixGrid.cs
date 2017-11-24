using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P03_PhoenixGrid
{
    class P03_PhoenixGrid
    {
        static void Main()
        {
            var input = Console.ReadLine();

            while (input != "ReadMe")
            {
                Regex pattern = new Regex(@"^([^\s_]{3}\.)+([^\s_]{3})*$");



                bool isValidMessage = pattern.IsMatch(input);
                bool isPalindrome = ChecksPalindrome(input);

                if ((isValidMessage && isPalindrome) || (isPalindrome && input.Length == 3))
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
