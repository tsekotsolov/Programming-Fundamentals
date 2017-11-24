using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Randomizer
{
    class P05_Randomizer
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var namesDict = new Dictionary<string, string>();
            Random rand = new Random();

            while (input != "end")
            {
                namesDict.Add(input, input);
                input = Console.ReadLine();
            }

            namesDict = namesDict.OrderBy(x => rand.Next())
              .ToDictionary(item => item.Key, item => item.Value);

            foreach (var name in namesDict)
            {
                Console.WriteLine($"{name.Value} - {name.Key}");
            }
        }
    }
}
