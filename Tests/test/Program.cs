using System;
using System.Collections.Generic;
using System.Linq;


namespace test
{
    class Program
    {
        class DataSet
        {
            public List<string> DataKey { get; set; }
            public List<long> DataSize { get; set; }
        }

        static void Main()
        {
            var input = Console.ReadLine().Split(" |->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            var listOfUniqueDataSets = new List<string>();
            var cache = new Dictionary<string, DataSet>();


            while (input[0] != "thetinggoesskrra")
            {
                if (input.Count == 1)
                {
                    FillsUniqueDataSetList(input, listOfUniqueDataSets);
                }

                else
                {
                    FillsCache(input, cache);

                }


                input = Console.ReadLine().Split(" |->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            PrintsResult(listOfUniqueDataSets, cache);

        }

        private static void FillsUniqueDataSetList(List<string> input, List<string> listOfUniqueDataSets)
        {
            if (!listOfUniqueDataSets.Contains(input[0]))
            {
                listOfUniqueDataSets.Add(input[0]);
            }
        }

        private static void FillsCache(List<string> input, Dictionary<string, DataSet> cache)
        {
            var dataSetKey = input[2];
            var dataKey = input[0];
            var dataSize = long.Parse(input[1]);

            DataSet dataSet = new DataSet();

            var dataKeyList = new List<string>();

            dataKeyList.Add(dataKey);

            var dataSizeList = new List<long>();
            dataSizeList.Add(dataSize);

            dataSet.DataKey = dataKeyList;
            dataSet.DataSize = dataSizeList;


            if (!cache.ContainsKey(dataSetKey))
            {
                cache.Add(dataSetKey, dataSet);
            }


            else
            {
                cache[dataSetKey].DataKey.AddRange(dataKeyList);

                cache[dataSetKey].DataSize.AddRange(dataSizeList);
            }
        }

        private static void PrintsResult(List<string> listOfUniqueDataSets, Dictionary<string, DataSet> cache)
        {
            var sortedCache = cache.OrderByDescending(x => x.Value.DataSize.Sum());

            foreach (var dataset in sortedCache)
            {
                if (listOfUniqueDataSets.Contains(dataset.Key))
                {
                    Console.WriteLine($"Data Set: {dataset.Key}, Total Size: {dataset.Value.DataSize.Sum()}");

                    foreach (var datakey in dataset.Value.DataKey)
                    {
                        Console.WriteLine($"$.{datakey}");
                    }

                    break;

                }


            }
        }
    }
}
