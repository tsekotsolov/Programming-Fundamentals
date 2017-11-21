using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P02_Convert_from_Base_N_to_Base_10
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToList();


            var baseN = int.Parse(input[0]);
            var numbertoConvert = input[1].ToCharArray();

           BigInteger bag = new BigInteger();

            for (int i = numbertoConvert.Length - 1, n = 0; i >= 0; i--, n++)
            {
                BigInteger num = new BigInteger(char.GetNumericValue(numbertoConvert[n]));
                BigInteger forSum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(baseN), i));
                bag += forSum;
            }



            Console.WriteLine(bag.ToString());

        }
    }
}
