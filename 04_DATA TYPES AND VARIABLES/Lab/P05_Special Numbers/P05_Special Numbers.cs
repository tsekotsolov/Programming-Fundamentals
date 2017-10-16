using System;

namespace P05_Special_Numbers
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            
            for (int i = 1; i <= Int32.Parse(number); i++)
            {
                int sumOfDigits = 0;
                foreach (var symbol in i.ToString())
                {
                    int digit = (symbol - '0');
                    sumOfDigits += digit;
                }

                bool isSpecial = (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
