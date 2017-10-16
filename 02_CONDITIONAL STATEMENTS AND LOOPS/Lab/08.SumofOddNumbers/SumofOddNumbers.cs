using System;
namespace _08.SumofOddNumbers
{
    class SumofOddNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= 2*n; i++)
            {
                if (i%2 !=0)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
