using System;
namespace P06_IntervalOfNumbers
{
    class P06_IntervalOfNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b>a)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }

            else
            {
                for (int i = b; i <= a; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
