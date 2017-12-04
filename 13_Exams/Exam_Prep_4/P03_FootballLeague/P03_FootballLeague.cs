using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03_FootballLeague
{
    class P03_FootballLeague
    {
        static void Main()
        {
            var key = Console.ReadLine();
            var input = Console.ReadLine();

            var tableResult = new Dictionary<string, int>();
            var goalStatistics = new Dictionary<string, long>();


            while (input != "final")
            {


                var tokens = input.Split();

                string firstTeam = GetTeam(key, tokens[0]);
                string secondTeam = GetTeam(key, tokens[1]);

                var scorePattern = @"([0-9]+):([0-9]+)$";
                Regex regex = new Regex(scorePattern);
                Match match = regex.Match(tokens[2]);

                var firstTeamGoals = long.Parse(match.Groups[1].ToString());
                var secondTeamGoals = long.Parse(match.Groups[2].ToString());

                int firstTeamPoints, secondTeamPoints;

                GetPoints(firstTeamGoals, secondTeamGoals, out firstTeamPoints, out secondTeamPoints);

                UpdateTableResults(tableResult, firstTeam, secondTeam, firstTeamPoints, secondTeamPoints);

                UpdateGoalStatistics(goalStatistics, firstTeam, secondTeam, firstTeamGoals, secondTeamGoals);


                input = Console.ReadLine();
            }

            PrintResults(tableResult, goalStatistics);

        }

        private static void GetPoints(long firstTeamGoals, long secondTeamGoals, out int firstTeamPoints, out int secondTeamPoints)
        {
            firstTeamPoints = 0;
            secondTeamPoints = 0;
            if (firstTeamGoals > secondTeamGoals)
            {
                firstTeamPoints = 3;

            }

            else if (secondTeamGoals > firstTeamGoals)
            {
                secondTeamPoints = 3;

            }
            else
            {
                firstTeamPoints = 1;
                secondTeamPoints = 1;
            }
        }

        private static string GetTeam(string key, string input)
        {
            var IndexOfKey = input.IndexOf(key);
            var middlePart = input.Substring(IndexOfKey + key.Length);
            IndexOfKey = middlePart.IndexOf(key);
            var team = Reverse(middlePart.Substring(0, IndexOfKey).ToUpper());
            return team;
        }

        public static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        private static void UpdateGoalStatistics(Dictionary<string, long> goalStatistics, string firstTeam, string secondTeam, long firstTeamGoals, long secondTeamGoals)
        {
            if (!goalStatistics.ContainsKey(firstTeam))
            {
                goalStatistics.Add(firstTeam, firstTeamGoals);
            }
            else
            {
                goalStatistics[firstTeam] += firstTeamGoals;
            }


            if (!goalStatistics.ContainsKey(secondTeam))
            {
                goalStatistics.Add(secondTeam, secondTeamGoals);
            }
            else
            {
                goalStatistics[secondTeam] += secondTeamGoals;
            }
        }

        private static void UpdateTableResults(Dictionary<string, int> tableResult, string firstTeam, string secondTeam, int firstTeamPoints, int secondTeamPoints)
        {
            if (!tableResult.ContainsKey(firstTeam))
            {
                tableResult.Add(firstTeam, firstTeamPoints);
            }
            else
            {
                tableResult[firstTeam] += firstTeamPoints;
            }

            if (!tableResult.ContainsKey(secondTeam))
            {
                tableResult.Add(secondTeam, secondTeamPoints);
            }
            else
            {
                tableResult[secondTeam] += secondTeamPoints;
            }
        }

        private static void PrintResults(Dictionary<string, int> tableResult, Dictionary<string, long> goalStatistics)
        {
            Console.WriteLine("League standings:");
            var place = 1;

            foreach (var team in tableResult.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{place++}. {team.Key} {team.Value}");
            }



            Console.WriteLine("Top 3 scored goals:");
            var counter = 0;

            foreach (var team in goalStatistics.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (counter > 2)
                {
                    break;
                }
                Console.WriteLine($"- {team.Key} -> {team.Value}");
                counter++;
            }
        }

       
    }
}
