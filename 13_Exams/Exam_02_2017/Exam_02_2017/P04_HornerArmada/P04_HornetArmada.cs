using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_HornerArmada
{
    class P04_HornetArmada

    {
        class Legion
        {
            public string LegionName { get; set; }
            public int Activity { get; set; }
            public Dictionary<string, int> SoldierCount { get; set; } = new Dictionary<string, int>();

        }
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            Dictionary<string, Legion> allLegions = new Dictionary<string, Legion>();



            for (int i = 0; i < numberOfInputs; i++)
            {
                var inputLine = Console.ReadLine().Split(new char[] { '=', '-', '>', ':', ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                var lastActivity = int.Parse(inputLine.First());
                var legionName = inputLine.Skip(1).Take(1).First();
                var soldierType = inputLine.Skip(2).Take(1).First();
                var soldierCount = int.Parse(inputLine.Skip(3).First());

                Dictionary<string, int> soldiers = new Dictionary<string, int>();


                soldiers.Add(soldierType, soldierCount);

                Legion legion = new Legion()
                {
                    LegionName = legionName,
                    Activity = lastActivity,
                    SoldierCount = soldiers,
                };

                if (!allLegions.ContainsKey(legionName))
                {
                    allLegions.Add(legionName, legion);
                }

                else if (allLegions.ContainsKey(legionName) && !allLegions[legionName].SoldierCount.ContainsKey(soldierType))
                {
                    allLegions[legionName].SoldierCount.Add(soldierType, soldierCount);
                }

                else if (allLegions.ContainsKey(legionName) && soldiers.ContainsKey(soldierType))
                {

                    allLegions[legionName].SoldierCount[soldierType] += soldierCount;
                }

                if (lastActivity > allLegions[legionName].Activity)
                {
                    allLegions[legionName].Activity = lastActivity;
                }

            }

            var printCommand = Console.ReadLine().Split('\\');



            if (printCommand.Length > 1)
            {

                var activityMarker = int.Parse(printCommand.First());
                var soldierTypeMarker = printCommand.Skip(1).First();


                var output = new Dictionary<string, int>();

                foreach (var legion in allLegions)
                {
                    if (activityMarker > legion.Value.Activity)
                    {

                        output.Add(legion.Key, legion.Value.SoldierCount[soldierTypeMarker]);

                    }

                }

                var sortedOutput = from entry in output orderby entry.Value descending select entry;


                foreach (var item in sortedOutput)
                {

                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }

            else
            {
                var soldierTypeMarker = printCommand.First();

                var output = new Dictionary<string, int>();

                foreach (var legion in allLegions)
                {

                    if (legion.Value.SoldierCount.ContainsKey(soldierTypeMarker))
                    {
                        output.Add(legion.Key, legion.Value.Activity);

                    }
                }


                var sortedOutput = from entry in output orderby entry.Value descending select entry;

                foreach (var activity in sortedOutput)
                {
                    Console.WriteLine($"{activity.Value} : {activity.Key}");
                }

            }
        }


    }
}
