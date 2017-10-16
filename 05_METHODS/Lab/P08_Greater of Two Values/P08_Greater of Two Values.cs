using System;

namespace P08_Greater_of_Two_Values
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type=="int")
            {
                int firstDigit = int.Parse(Console.ReadLine());
                int secondDigit = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(firstDigit, secondDigit)); ;
            }

            else if (type=="char")

            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstChar, secondChar)); ;
            }

            else if (type=="string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                Console.WriteLine(GetMax(firstString, secondString)); ;
            }
        }

        static string GetMax(string firstString, string secondString)
        {
            
            if (String.Compare(firstString, secondString) < 0)
            {
                // firstString is less than secondString
                return secondString;
            }
            else
            {
                return firstString;
            }
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar>=secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
       
        static int GetMax(int firstDigit, int secondDigit)
        {
            if (firstDigit>=secondDigit)
            {
                return firstDigit;
            }

            else
            {
                return secondDigit;
            }

        }
    }
}
