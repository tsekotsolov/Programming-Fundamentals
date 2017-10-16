using System;

namespace P01_X
{
    class P01_X
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //top section
            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.WriteLine(new string(' ', i) + "x" + new string(' ', (n - 2 - 2 * i)) + "x");
            }

            //midsection
            Console.WriteLine(new string(' ', (n - 1) / 2) + "x" + new string(' ', (n - 1) / 2));

            //botoom section

            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.WriteLine(new string(' ', (n - 2 * i - 2) / 2) + "x" + new string(' ', 1 + 2 * i) + "x");
            }
        }
    }
}
