using System;


namespace P05_Fibonacci_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNthFibonacciNumber(n));
        }

        private static int FindNthFibonacciNumber(int n)
        {

            if (n==0)
            {
                return 1;
            }

            int a = 0;
            int b = 1;
            int currentFibNumber = 0;
            for (int i = 0; i < n; i++)
            {
                currentFibNumber = a + b;
                a = b;
                b = currentFibNumber;
            }

            return currentFibNumber;
        }
    }
}
