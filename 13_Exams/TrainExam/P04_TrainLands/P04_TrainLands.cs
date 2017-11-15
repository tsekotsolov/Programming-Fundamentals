using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_TrainLands
{
    class P04_TrainLands
    {
        class Train
        {
            public string WagonName { get; set; }
            public int WagonPower { get; set; }
        }

        static void Main()
        {
            var inputLine = Console.ReadLine();

            var mainTrain = new Dictionary<string, List<Train>>();

            while (inputLine != "It's Training Men!")
            {
                var input = inputLine.Split(new char[] { ' ', '-', '>', ':', }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                var trainList = new List<Train>();

                if (input.Count == 3 && !input.Contains("="))
                {
                    var trainName = input[0];
                    var wagonName = input[1];
                    var wagonPower = int.Parse(input[2]);

                    Train train = new Train()
                    {
                        WagonName = wagonName,
                        WagonPower = wagonPower
                    };

                    trainList.Add(train);

                    if (!mainTrain.ContainsKey(trainName))
                    {
                        mainTrain.Add(trainName, trainList);
                    }

                    else
                    {
                        mainTrain[trainName].AddRange(trainList);
                    }
                }

                else if (input.Count == 2 && !input.Contains("="))
                {
                    var trainName = input[0];
                    var otherTrain = input[1];

                    if (trainName == otherTrain)
                    {
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    else if (!mainTrain.ContainsKey(trainName))
                    {
                        mainTrain.Add(trainName, mainTrain[otherTrain]);
                        mainTrain.Remove(otherTrain);
                    }

                    else
                    {
                        mainTrain[trainName].AddRange(mainTrain[otherTrain]);
                        mainTrain.Remove(otherTrain);

                    }
                }

                else
                {
                    var trainName = input[0];
                    var otherTrain = input[2];

                    if (!mainTrain.ContainsKey(trainName))
                    {
                        mainTrain.Add(trainName, mainTrain[otherTrain]);

                    }

                    else
                    {
                        mainTrain[trainName].RemoveRange(0, mainTrain[trainName].Count);

                        mainTrain[trainName].AddRange(mainTrain[otherTrain]);
                    }


                }

                inputLine = Console.ReadLine();
            }


            var sortedTrain = new Dictionary<string, int>();

            foreach (var train in mainTrain)
            {
                var sum = 0;
                foreach (var wagon in train.Value)
                {
                    sum += wagon.WagonPower;
                }

                sortedTrain.Add(train.Key,sum);
                
            }

            var finalTrain = new Dictionary<string, List<Train>>();

            foreach (var item in sortedTrain.OrderByDescending(x=>x.Value))
            {
                
                finalTrain.Add(item.Key, mainTrain[item.Key]);
            }

            foreach (var train in finalTrain)
                
            {
                Console.WriteLine($"Train: {train.Key}");

                foreach (var wagon in train.Value.OrderByDescending(x => x.WagonPower))
                {
                    Console.WriteLine($"###{wagon.WagonName} - {wagon.WagonPower}");
                }
            }
        }
    }
}
