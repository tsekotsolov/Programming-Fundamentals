using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_HornetAssault
{
    class P03_HornetAssault
    {
        static void Main()
        {
            var beeHives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();


            var hornetsPower = hornets.Sum();

            for (int i = 0; i < beeHives.Count; i++)
            {
                if (hornetsPower > beeHives[i])
                {
                    beeHives[i] = 0;
                }
                else
                {
                    beeHives[i] -= hornetsPower;

                    if (hornets.Count>0)
                    {
                        hornets.RemoveAt(0);
                    }

                    hornetsPower = hornets.Sum();
                }
            }

            if (beeHives.Any(x => x != 0))
            {
                beeHives.RemoveAll(x => x == 0);
                Console.WriteLine(string.Join(" ", beeHives));
            }

            else if (hornets.Count != 0)
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
