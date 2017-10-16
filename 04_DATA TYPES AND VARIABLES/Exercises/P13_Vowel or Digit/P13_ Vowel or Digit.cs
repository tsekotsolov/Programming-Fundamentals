using System;


namespace P13_Vowel_or_Digit
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();

            bool isVowel = input == "a"||input=="e"||input=="o" || input == "i" ||input=="u";

            if (isVowel)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                try
                {
                    int digit = Int32.Parse(input);
                    Console.WriteLine("digit");
                }
                catch (Exception)
                {

                    Console.WriteLine("other");
                }

            }
        }
    }
}
