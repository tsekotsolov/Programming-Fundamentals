using System;

namespace P02_Number_Checker
{
    class Program
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());

            if (n-Math.Floor(n)==0)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
