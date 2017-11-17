using System;
using System.Collections.Generic;
using System.Linq;


namespace P02_WormsParty
{

    class P04_WormsParty
    {

        class Worm
        {
            public string WormName { get; set; }
            public long WormScore { get; set; }
        }

        static void Main()
        {
            var inputLine = Console.ReadLine();


            var teamsDictionary = new Dictionary<string, List<Worm>>();


            while (inputLine != "quit")
            {

                var command = inputLine
                 .Split(new[] { " -> ", " : ", " = " }, StringSplitOptions.None)
                 .ToList();

                var teamName = command[1];
                var wormName = command[0];
                var wormScore = long.Parse(command[2]);

                Worm worm = new Worm()
                {
                    WormName = wormName,
                    WormScore = wormScore
                };

                if (teamsDictionary.Values.Any(x => x.Any(y => y.WormName.Contains(wormName))))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                if (!teamsDictionary.ContainsKey(teamName))
                {
                    teamsDictionary[teamName] = new List<Worm>();
                }

                teamsDictionary[teamName].Add(worm);

                inputLine = Console.ReadLine();

            }

            var sortedTeamsDictionary = teamsDictionary
                .OrderByDescending(x => x.Value.Sum(y => y.WormScore))
                .ThenByDescending((x => x.Value.Sum(y => y.WormScore / x.Value.Count)));

            var i = 1;

            foreach (var team in sortedTeamsDictionary)

            {
                Console.WriteLine($"{i}. Team: {team.Key} - {team.Value.Sum(y => y.WormScore)}");

                foreach (var worm in team.Value.OrderByDescending(x => x.WormScore))
                {

                    Console.WriteLine($"###{worm.WormName} : {worm.WormScore}");

                }

                i++;
            }

        }

    }

}



