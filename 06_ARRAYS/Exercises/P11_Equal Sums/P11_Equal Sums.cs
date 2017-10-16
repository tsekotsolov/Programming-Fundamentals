using System;

using System.Linq;


namespace P11_Equal_Sums
{
    class Program
    {
        static void Main()
        {
            int[] myArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            bool isThereSuchANumber = false;


            for (int i = 0; i < myArray.Length; i++)
            {
                int[] leftArray = myArray.Take(i).ToArray();
                int[] rightArray = myArray.Skip(i+1).ToArray();

                if (leftArray.Sum()==rightArray.Sum())
                {
                    Console.WriteLine(i);
                    isThereSuchANumber = true;
                    break;
                }
            }

            if (!isThereSuchANumber)
            {
                Console.WriteLine("no");
            }
        }
    }
}
