using System;
using System.Linq;

namespace P04_Character_Multiplier
{
    class  Multiplier
    {
        static void Main()
        {

            var input = Console.ReadLine().Split().ToList();
            var firstString = input[0].ToCharArray();
            var secondString = input[1].ToCharArray();

            var cycleIterrations = Math.Min(firstString.Length, secondString.Length);

            var sum = 0;

            for (int i = 0; i < cycleIterrations; i++)
            {
                var product = firstString[i] * secondString[i];
                sum += product;
            }

            if (firstString.Length != secondString.Length)
            {

                var resultString = (firstString.Length > secondString.Length) ?
                    input[0].Substring(secondString.Length) : input[1].Substring(firstString.Length);

                foreach (var ch in resultString)
                {
                    sum += ch;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
