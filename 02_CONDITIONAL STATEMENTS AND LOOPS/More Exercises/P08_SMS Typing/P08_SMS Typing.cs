using System;
namespace P08_SMS_Typing
{
    class Program
    {
        static void Main()
        {
            int numberOfChars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfChars; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                int mainDigit = inputNumber % 10;
                int numberofDigits = inputNumber.ToString().Length;


                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                int letterIndex = offset + numberofDigits - 1;

                int letter = letterIndex + 97;



                if (mainDigit == 0)
                {
                    Console.Write(" ");
                }

                else
                {
                    Console.Write((char)letter);
                }

            }

        }
    }
}
