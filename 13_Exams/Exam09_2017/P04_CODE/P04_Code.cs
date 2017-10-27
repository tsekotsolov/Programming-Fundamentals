using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    TeamMembers = members,

                };

                if (!majorSquad.ContainsKey(teamLeader) && teamLeader != teamMember)
                {
                    majorSquad.Add(teamLeader, squad);
                }

                else if (majorSquad.ContainsKey(teamLeader) && teamLeader != teamMember && !majorSquad[teamLeader].TeamMembers.Contains(teamMember))


                {
                    majorSquad[teamLeader].TeamMembers.AddRange(members);

                }



                //majorSquad[teamLeader]!=majorSquad[teamMember] //dali tekustia chlen ne e niakade lider
                //bool istrue = majorSquad[teamLeader].TeamMembers.Contains(teamMember) != majorSquad[teamMember].TeamMembers.Contains(teamLeader);


                input = Console.ReadLine();
            }

        }
    }
}
