using System;
using System.Linq;


namespace P09_Index_of_Letters
{
    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} -> {input[i] - 97}");
            }
            
        }
    }
}
