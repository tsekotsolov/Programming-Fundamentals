using System;
using System.Linq;


namespace P04_Triple_Sum
{
    class Program
    {
        static void Main()
        {

            int[] numbers = Console.ReadLine()
                .Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            bool checker = false;

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = i+1; j < numbers.Length; j++)
                {
                   

                    if (numbers.Contains(numbers[i]+numbers[j]))
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[i] + numbers[j]}");

                        checker = true;
                    }
                }
            }

            if (!checker)
            {
                Console.WriteLine("no");
            }


        }
    }
}
