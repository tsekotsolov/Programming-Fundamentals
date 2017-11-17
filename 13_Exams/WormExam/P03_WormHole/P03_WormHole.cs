using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_WormHole
{
    class P03_WormHole
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Split().Select(int.Parse).ToList();
            var steps = 0;

            for (int i = 0; i < inputLine.Count; i++)
            {
                if (inputLine[i]==0)
                {
                    steps++;
                }

                else
                {
                    var currentValueAti = inputLine[i];
                    inputLine[i] = 0;
                    i = currentValueAti-1;
                    
                }
               
            }

            Console.WriteLine(steps);
        }
    }
}
