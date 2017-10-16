using System;
using System.Linq;

namespace P10_SumofDigitInArray
{
    class P10_SumofDigitInArray
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            string[] userStringArray = userInput.Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(string.Join(",", userStringArray));

            int[] userIntArray = new int[userStringArray.Length];

            try
            {
                for (int i = 0; i < userIntArray.Length; i++)
                {
                    userIntArray[i] = int.Parse(userStringArray[i]);
                }

                int sumEvenNumbers = 0;
                int sumOddNumbers = 0;
                for (int i = 0; i < userIntArray.Length; i++)
                {

                    if (userIntArray[i] % 2 == 0)
                    {
                        sumEvenNumbers += userIntArray[i];
                    }

                    else
                    {
                        sumOddNumbers += userIntArray[i];
                    }
                }

                Console.WriteLine(sumEvenNumbers);
                Console.WriteLine(sumOddNumbers);
                Console.WriteLine(string.Join(" ", userIntArray.Reverse()));
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid symbols in array sequence");
            }

        }

        }
    }


