using System;

namespace P09_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(MultiplyOddAndEvenSum(number));
        }

        private static int MultiplyOddAndEvenSum(int number)
        {
            int oddSum = 0;
            int evenSum = 0;
            while (number>0)
            {
                int lastDigit = number % 10;

                if (lastDigit%2==0)
                {
                    evenSum += lastDigit;
                }
                else
                {
                    oddSum += lastDigit;
                }

                number /= 10;
            }

            return oddSum * evenSum;
        }
    }
}
