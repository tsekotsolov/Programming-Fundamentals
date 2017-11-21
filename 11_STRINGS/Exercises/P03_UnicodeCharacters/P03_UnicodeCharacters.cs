using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_UnicodeCharacters
{
    class P03_UnicodeCharacters
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            StringBuilder bag = new StringBuilder();


            foreach (var symbol in input)
            {
                bag.Append($"\\u{((int)symbol).ToString("x4")}");
            }
            var result = bag.ToString();
            Console.WriteLine(result);
        }

    }
}
