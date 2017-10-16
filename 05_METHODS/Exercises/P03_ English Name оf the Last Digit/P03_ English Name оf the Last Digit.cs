using System;

namespace P03__English_Name_оf_the_Last_Digit
{
    class Program
    {
        static void Main()
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));

            Console.WriteLine(GetLastDigit(number)); 

        }

        static string GetLastDigit (long number)
        {
            long lastDigit = number%10;

            if (lastDigit == 0)
            {
                return "zero";
            }
            else if (lastDigit == 1)
            {
                return "one";
            }
            else if (lastDigit == 2)
            {
                return "two";
            }
            else if (lastDigit == 3)
            {
                return "three";
            }
            else if (lastDigit == 4)
            {
                return "four";
            }
            else if (lastDigit == 5)
            {
                return "five";
            }
            else if (lastDigit == 6)
            {
                return "six";
            }
            else if (lastDigit == 7)
            {
                return "seven";
            }
            else if (lastDigit == 8)
            {
                return "eight";
            }
            else  
            {
                return "nine";
            }
        }
    }
}
