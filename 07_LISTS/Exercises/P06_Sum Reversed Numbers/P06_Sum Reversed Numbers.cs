using System;
using System.Linq;

namespace P06_Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            long result = Console.ReadLine()
                .Split()
                .Select(a => long.Parse(new string(a.Reverse().ToArray())))
                .Sum();

            Console.WriteLine(result);
        }
    }
}
