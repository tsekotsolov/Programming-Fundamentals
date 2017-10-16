using System;
namespace P10_TriangleofNumbers
{
    class P10_TriangleofNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
               
                for (int a = 1; a <= i; a++)
                {   
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }

        }
    }
}
