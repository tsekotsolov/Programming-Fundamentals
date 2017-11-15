using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Trainers
{
    class P01_Trainers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var teamsmoney = new Dictionary<string, decimal>();
            teamsmoney.Add("Practical", 0m);
            teamsmoney.Add("Technical", 0m);
            teamsmoney.Add("Theoretical", 0m);

            for (int i = 0; i < n; i++)
            {
                var distanceInMiles = long.Parse(Console.ReadLine());
                var cargoInTons = decimal.Parse(Console.ReadLine());
                var team = Console.ReadLine();

                decimal participantEarnedMoney = (cargoInTons * 1000M * 1.5M) 
                    - (0.7M * distanceInMiles * 1600M * 2.5M);

                    teamsmoney[team] += participantEarnedMoney;
                
            }

            foreach (var team in teamsmoney)
            {
                var maxValue = teamsmoney.Values.Max();

                if (team.Value==maxValue)
                {
                    Console.WriteLine($"The {team.Key} Trainers win with ${team.Value:f3}.");
                }
            }

        }
    }
}
