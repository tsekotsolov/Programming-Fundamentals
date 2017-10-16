using System;

namespace P03_PrintingTriangle
{
    class P03_PrintingTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
                Console.WriteLine();
            }

            for (int i = n-1; i >= 1; i--)
            {
                PrintLine(i);
                Console.WriteLine();
            }
        }

        static void PrintLine(int k)
        {
            for (int i = 1; i <= k; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
