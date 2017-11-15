using System;
using System.Collections.Generic;
using System.Linq;


namespace P04_TrainLands
{
    class P04_TrainLands
    {
        class Train
        {
            public string WagonName { get; set; }
            public long WagonPower { get; set; }
        }

        static void Main()
        {
            var inputLine = Console.ReadLine();

            var mainTrain = new Dictionary<string, List<Train>>();

            while (inputLine != "It's Training Men!")
            {
                var input = inputLine
                 .Split(new char[] { ' ', '-', '>', ':', }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

                

                if (input.Count == 3 && !input.Contains("="))
                {
                    var trainName = input[0];
                    var wagonName = input[1];
                    var wagonPower = long.Parse(input[2]);

                    
                    Train train = new Train()
                    {
                        WagonName = wagonName,
                        WagonPower = wagonPower
                    };

                    
                    if (!mainTrain.ContainsKey(trainName))
                    {
                        mainTrain[trainName]=new List<Train>();
                    }

                    mainTrain[trainName].Add(train);
                    
                }

                else if (input.Count == 2 && !input.Contains("="))
                {
                    var trainName = input[0];
                    var otherTrain = input[1];

                 
                    if (!mainTrain.ContainsKey(trainName))
                    {
                        mainTrain[trainName]= new List<Train>();
                       
                    }

                   
                    mainTrain[trainName].AddRange(mainTrain[otherTrain]);
                        
                    
                
                    mainTrain.Remove(otherTrain);
                }

                else
                {
                    var trainName = input[0];
                    var otherTrain = input[2];

                    if (!mainTrain.ContainsKey(trainName))
                    {
                        mainTrain[trainName] = new List<Train>();
                    }

                    
                        mainTrain[trainName].Clear();

                        mainTrain[trainName].AddRange(mainTrain[otherTrain]);
                    

                }

                inputLine = Console.ReadLine();
            }

            var sTrain = mainTrain.OrderByDescending(t => t.Value.Sum(p => p.WagonPower))
                .ThenBy(t => t.Value.Count); ;

          

            foreach (var train in sTrain)

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
