using System;
using System.Linq;


namespace P06_Reverse_an_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.WriteLine(string.Join(" ", array.Reverse()));
        }
    }
}
