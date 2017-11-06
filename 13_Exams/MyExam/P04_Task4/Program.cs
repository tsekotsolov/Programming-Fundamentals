using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Task4
{
    class Program
    {

        class Data
        {
            public string DataSet { get; set; }
            public int DataSize { get; set; }
            public string DataKey { get; set; }
        }
        static void Main()
        {
            var inputLine = Console.ReadLine();


            List<string> dataSetList = new List<string>();

            Dictionary<string, List<Data>> MajorData = new Dictionary<string, List<Data>>();

            Dictionary<string, List<Data>> Cache = new Dictionary<string, List<Data>>();

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

                    if (Cache.ContainsKey(dataSet))
                    {
                        MajorData.Add(dataSet, Cache[dataSet]);
                    }
                }

                else
                {
                    var dataKey = input[0];
                    var dataSize = int.Parse(input[1]);
                    var dataSet = input[2];

                    Data data = new Data()
                    {
                        DataSet = dataSet,
                        DataKey = dataKey,
                        DataSize = dataSize,
                    };

                    listOfData.Add(data);

                    if (dataSetList.Contains(dataSet) && !MajorData.ContainsKey(dataSet))

                    {
                        MajorData.Add(dataSet, listOfData);
                    }

                    else if (dataSetList.Contains(dataSet) && MajorData.ContainsKey(dataSet))
                    {
                        MajorData[dataSet].AddRange(listOfData);
                    }

                    if (!MajorData.ContainsKey(dataSet))
                    {
                        if (!Cache.ContainsKey(dataSet))
                        {
                            Cache.Add(dataSet, listOfData);
                        }


                        else if (Cache.ContainsKey(dataSet))
                        {
                            Cache[dataSet].AddRange(listOfData);
                        }
                    }


                }

                inputLine = Console.ReadLine();
            }


            foreach (var data in MajorData)
            {
                foreach (var item in MajorData.Values)
                {
                   
                }

            }
        }
    }
}
