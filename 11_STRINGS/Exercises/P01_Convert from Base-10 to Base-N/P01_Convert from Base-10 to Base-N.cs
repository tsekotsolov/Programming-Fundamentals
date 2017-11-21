using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace P01_Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToList();

            var numbertoConvert = input[1];
            var baseN = input[0];

            StringBuilder bag = new StringBuilder();

            while (numbertoConvert!=0)
            {
                var remainder = numbertoConvert % baseN;
                numbertoConvert /= baseN;
                bag.Append(remainder.ToString());
            }

            var reversed = bag.ToString();
            char[] charArray = reversed.ToCharArray();
            Array.Reverse(charArray);
            reversed = new string(charArray);

            Console.WriteLine(reversed);
        }
    }
}
