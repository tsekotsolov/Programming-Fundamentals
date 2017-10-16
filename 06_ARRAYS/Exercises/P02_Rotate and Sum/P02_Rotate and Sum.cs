using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Rotate_and_Sum
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rotationCount = int.Parse(Console.ReadLine());

            int[] sum = new int[input.Length];

            for (int i = 0; i < rotationCount; i++)
            {
                RotateRightOnce(input);

                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] = sum[j] + input[j];
                }
            }

            Console.WriteLine(String.Join(" ", sum));
        }

        public static void RotateRightOnce(int[] input)
        {
            var last = input.Length - 1;
            for (var i = 0; i < last; i += 1)
            {
                input[i] ^= input[last];
                input[last] ^= input[i];
                input[i] ^= input[last];
            }
        }
    }
}
