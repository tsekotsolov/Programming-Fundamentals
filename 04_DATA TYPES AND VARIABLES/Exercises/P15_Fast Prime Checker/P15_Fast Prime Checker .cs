using System;

namespace P15_Fast_Prime_Checker
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int currentNumber = 2; currentNumber <= n; currentNumber++)
            {
                bool isPrime = true;

                for (int divisor = 2; divisor <= Math.Sqrt(currentNumber); divisor++)
                {
                    if (currentNumber % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }

        }
    }
}
