using System;

namespace P12_Master_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 7; i <= number; i++)
            {

                bool isPalindrome = IsPalindrome(i.ToString());
                bool isDivisibleBy7 = IsDivisibleBy7(i);
                bool doesContainEvenDigit = DoesContainEvenDigit(i);
                if (isPalindrome && isDivisibleBy7 && doesContainEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static bool DoesContainEvenDigit(int number)
        {
            while (number>0)
            {
               int digit = number % 10;
                if (digit%2==0)
                {
                    return true;
                }
               number = number / 10;
            }
            return false;
        }

        private static bool IsDivisibleBy7(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsPalindrome(string n)
        {
            int length = n.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (n[i] != n[length - i - 1])
                    return false;
            }

            return true;
        }
    }
}
