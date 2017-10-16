using System;
namespace P12_Test_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int combinationCounter = 0;
            int productSum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int k = 1; k <= m; k++)
                {

                    if (productSum >= maxSum)
                    {          
                        break;
                    }
                    combinationCounter++;
                    productSum += (3 * i * k);
                }
            }

            Console.WriteLine( $"{combinationCounter} combinations");
            if (productSum>=maxSum)
            {
                Console.WriteLine($"Sum: {productSum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"Sum: {productSum}");
            }
        }
    }
}
