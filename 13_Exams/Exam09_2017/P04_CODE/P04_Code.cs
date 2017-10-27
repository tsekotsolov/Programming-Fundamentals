using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_CODE
{
    class P04_Code
    {
        class Squad
        {
            public string TeamLeader { get; set; }

            public List<string> TeamMembers { get; set; } = new List<string>();
        }
        static void Main()
        {
            var input = Console.ReadLine();

            Dictionary<string, Squad> majorSquad = new Dictionary<string, Squad>();

            while (input != "Blaze it!")
            {
                var inputLine = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var teamLeader = inputLine.First();
                var teamMember = inputLine.Skip(1).First();
                
                List<string> members = new List<string>();
                members.Add(teamMember);

                Squad squad = new Squad()
                {
                    TeamLeader = teamLeader,
                    TeamMembers = members
                };
                
                if (!majorSquad.ContainsKey(teamLeader) && teamLeader != teamMember)
                {
                    majorSquad.Add(teamLeader, squad);

                }
                else if (majorSquad.ContainsKey(teamLeader) && teamLeader != teamMember
                    && !majorSquad[teamLeader].TeamMembers.Contains(teamMember))

                {
                    majorSquad[teamLeader].TeamMembers.AddRange(members);
                }

                input = Console.ReadLine();
            }

            var newDict = new Dictionary<string, int>();
            foreach (var teamleader in majorSquad)
            {
                var teamMembersCount = teamleader.Value.TeamMembers.Count;

                var team = teamleader.Value.TeamMembers;

                for (int i = 0; i < team.Count; i++)
                {
                    if (majorSquad.ContainsKey(team[i]) && majorSquad[team[i]].TeamMembers.Contains(teamleader.Key))
                    {
                        teamMembersCount--;
                    }
                }

                newDict.Add(teamleader.Key, teamMembersCount);
            }
            foreach (var teamleader in newDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{teamleader.Key} : {teamleader.Value} ");
            }
        }
    }
}
