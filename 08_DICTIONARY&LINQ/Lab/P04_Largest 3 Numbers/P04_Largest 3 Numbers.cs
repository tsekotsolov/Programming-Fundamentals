using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Largest_3_Numbers
{
    class Program
    {
        static void Main()
        {

            var nums = Console.ReadLine()
         .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
         .Select(int.Parse)
         .ToList();

           var result = nums.OrderByDescending(x => x).Take(3);

           Console.WriteLine(string.Join(", ",result));
        }
    }
}
