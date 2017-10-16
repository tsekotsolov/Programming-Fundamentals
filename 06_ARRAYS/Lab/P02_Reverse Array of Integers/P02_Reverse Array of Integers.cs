using System;
using System.Linq;


namespace P02_Reverse_Array_of_Integers
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine(string.Join(" ", numbers.Reverse()));

         

        }
    }
}
