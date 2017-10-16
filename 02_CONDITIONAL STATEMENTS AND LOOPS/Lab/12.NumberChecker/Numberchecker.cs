using System;
namespace _12.NumberChecker
{
    class Numberchecker
    {
        static void Main()

        {
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("It is a number.");
                    break;

                }
                catch
                {
                    Console.WriteLine("Invalid input!");
                }
            }
           
        }
    }
}
