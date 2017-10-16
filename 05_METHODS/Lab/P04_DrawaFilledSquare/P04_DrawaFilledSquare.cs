using System;

namespace P04_DrawaFilledSquare
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderFooter(n);

            for (int i = 1; i <= n-2; i++)
            {
                PrintBody(n);
            }
            
            PrintHeaderFooter(n);

        }

        static void PrintBody(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-',2*n));
        }
    }
}
