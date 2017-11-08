using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Task4
{
    class Program
    {
        class Data
        {
            public long DataSize { get; set; }
            public string DataKey { get; set; }
        }
        static void Main()
        {

            var inputLine = Console.ReadLine();

   
            List<string> dataSetList = new List<string>();

            Dictionary<string, List<Data>> MajorData = new Dictionary<string, List<Data>>();

            Dictionary<string, List<Data>> cache = new Dictionary<string, List<Data>>();

            while (inputLine != "thetinggoesskrra")
            {
                var input = inputLine.Split(new char[] { ' ', '|', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();


                List<Data> listOfData = new List<Data>();

             
                if (input.Count == 1)
                {
                    var dataSet = input[0];

                    if (!MajorData.ContainsKey(dataSet))
                    {
                        dataSetList.Add(dataSet);
                    }

                    if (cache.ContainsKey(dataSet))
                    {
                        MajorData.Add(dataSet, cache[dataSet]);
                    }
                }

                else 
                {
                    var dataKey = input[0];
                    var dataSize = long.Parse(input[1]);
                    var dataSet = input[2];

                    Data data = new Data()
                    {
                        DataKey = dataKey,
                        DataSize = dataSize,
                    };

                    listOfData.Add(data);

                    if (dataSetList.Contains(dataSet) && !MajorData.ContainsKey(dataSet))

                    {
                        MajorData.Add(dataSet, listOfData);
                    }

                    else if (MajorData.ContainsKey(dataSet))
                    {
                        MajorData[dataSet].AddRange(listOfData);
                    }

                    if (!MajorData.ContainsKey(dataSet))
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache.Add(dataSet, listOfData);
                        }

                        else if (cache.ContainsKey(dataSet))
                        {
                            cache[dataSet].AddRange(listOfData);
                        }
                    }

                }

                inputLine = Console.ReadLine();
            }

            if (MajorData.Count!=0)
            {
                var maxSum = long.MinValue;
                var highestSumDataSet = "unknown";

                foreach (var data in MajorData)
                {
                    var sum = 0L;

                    foreach (var item in data.Value)
                    {
                        sum += item.DataSize;
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            highestSumDataSet = data.Key;

                        }
                    }
                }

                Console.WriteLine($"Data Set: {highestSumDataSet }, Total Size: {maxSum}");

                foreach (var item in MajorData)
                {
                    if (item.Key == highestSumDataSet)
                    {
                        foreach (var set in item.Value)
                        {
                            Console.WriteLine($"$.{set.DataKey}");
                        }
                    }
                }
            }
        }
    }
}
