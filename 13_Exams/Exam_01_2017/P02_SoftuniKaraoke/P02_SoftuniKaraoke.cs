using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_SoftuniKaraoke
{
    class P02_SoftuniKaraoke
    {
        class Singer
        { 
            public List<string> Awards { get; set; }
        }

        static void Main()
        {
            var particiantsList = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            var songsList = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

            var command = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

            var contestResults = new Dictionary<string, Singer>();

            while (command[0] != "dawn")
            {
                var singerName = command[0];
                var currentSong = command[1];
                var currentAward = command[2];

                var currentAwardList = new List<string>();
                currentAwardList.Add(currentAward);

                Singer singer = new Singer();

                singer.Awards = currentAwardList;

                bool isInBothLists = particiantsList.Contains(singerName) && songsList.Contains(currentSong);

                if (isInBothLists)
                {

                    if (!contestResults.ContainsKey(singerName))
                    {
                        contestResults.Add(singerName, singer);
                    }


                    if (!contestResults[singerName].Awards.Contains(currentAward))
                    {
                        contestResults[singerName].Awards.Add(currentAward);
                    }

                }

                command = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            }

            if (contestResults.Count!=0)
            {
                foreach (var singer in contestResults.OrderByDescending(x => x.Value.Awards.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{singer.Key}: {singer.Value.Awards.Count} awards");

                    foreach (var award in singer.Value.Awards.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }

                }
            }

            else
            {
                Console.WriteLine("No awards");
            }

          

        }
    }
}
