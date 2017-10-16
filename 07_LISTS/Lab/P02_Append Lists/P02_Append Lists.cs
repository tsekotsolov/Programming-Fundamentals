using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Append_Lists
{
    class Program
    {
        static void Main()
        {

            var input = Console.ReadLine()
           .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
           .ToList();

            input.Reverse();
            List<string> result = new List<string>();


            foreach (var item in input)
            {
                List < string > nums= item.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(nums);
            }


            Console.WriteLine(string.Join(" ", result));
        }

    }
}
