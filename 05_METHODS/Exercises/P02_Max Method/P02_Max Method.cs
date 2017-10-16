using System;

namespace P02_Max_Method
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = MaxValue(MaxValue(firstNumber, secondNumber), thirdNumber);

            Console.WriteLine(result);
        }

        static int MaxValue(int firtsNumber, int secondNumber)

        {
            if (firtsNumber >= secondNumber)
            {
                return firtsNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
