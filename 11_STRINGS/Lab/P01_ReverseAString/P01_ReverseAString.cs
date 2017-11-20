namespace P01_ReverseAString
{
    using System;
    using System.Linq;

    class P01_ReverseAString
    {
        static void Main()
        {
            var input = Console.ReadLine().ToArray();
            var reversed = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                reversed[i] = input[input.Length - i - 1];
            }

            Console.WriteLine(string.Join("", reversed));
        }
    }
}
