using System;


namespace P06_Prime_Checker
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(number));

        }

        static bool IsPrime(long n)
        {
            if (n==0||n==1)
            {
                return false;
            }
            
            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                long checker = n % i;

                if (checker == 0)
                {
                    return false;
                }    
            }

            return true;

        }
    }
}
