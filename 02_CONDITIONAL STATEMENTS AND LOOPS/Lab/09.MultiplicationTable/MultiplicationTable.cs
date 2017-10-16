using System;

namespace _09.MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {i*number}");
            }

        }
    }
}
