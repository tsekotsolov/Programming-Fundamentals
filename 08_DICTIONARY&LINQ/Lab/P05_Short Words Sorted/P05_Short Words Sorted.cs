using System;
using System.Linq;

namespace P05_Short_Words_Sorted
{
    class Program
    {
        static void Main()
        {

            var nums = Console.ReadLine()
           .ToLower()
           .Split(new[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
           .ToList();

            var result = nums
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct();

            Console.WriteLine(string.Join(", " , result));
        }
    }
}
