using System;
using System.Collections.Generic;
using System.Linq;


namespace P03_Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main()
        {

            var numbers = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToList();


            for (int i = 0; i < numbers.Count - 1; i++)
            {
                while (i < numbers.Count - 1)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] = (numbers[i] + numbers[i + 1]);

                        numbers.RemoveAt(i + 1);

                        if (i > 0)
                        {
                            i--;
                        }
                    }
                    else
                    {
                        i++;
                    }

                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
