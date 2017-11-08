using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02_Task2
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var commandSequence = Console.ReadLine().Split().ToArray();

            while (commandSequence[0] != "3:1")
            {
                if (commandSequence[0] == "merge")
                {
                    var startIndex = int.Parse(commandSequence[1]);
                    var endIndex = int.Parse(commandSequence[2]);

                    startIndex = MakeSureIsInRange(startIndex, inputLine.Count);
                    endIndex = MakeSureIsInRange(endIndex, inputLine.Count);

                    if (inputLine.Count == 1)
                    {
                        commandSequence = Console.ReadLine().Split().ToArray();
                        continue;
                    }

                    MergeList(inputLine, startIndex, endIndex);

                }

                else if (commandSequence[0] == "divide")
                {
                    var index = int.Parse(commandSequence[1]);
                    var partitions = int.Parse(commandSequence[2]);

                    DivideList(inputLine, index, partitions);

                }

                commandSequence = Console.ReadLine().Split().ToArray();

            }


            Console.WriteLine(string.Join(" ", inputLine));

        }

        static void DivideList(List<string> inputLine, int index, int partitions)
        {
            var sack = new List<string>();
            var inputString = inputLine[index];
            bool isModified = false;

            if (partitions != 0)
            {
                if (inputString.Length == partitions)
                {
                    foreach (var s in inputString)
                    {
                        sack.Add(s.ToString());
                    }
                    isModified = true;
                }


                else if (inputString.Length % partitions == 0)
                {

                    for (int i = 0; i < inputString.Length; i += inputString.Length / partitions)
                    {
                        string sub = inputString.Substring(i, inputString.Length / partitions);
                        sack.Add(sub);
                    }
                    isModified = true;
                }

                else
                {
                    if (inputString.Length > partitions)
                    {
                        var numberOfChars = inputString.Length / partitions;
                        var firstPartLenght = numberOfChars * (partitions - 1);
                        var lastElement = inputString.Substring(firstPartLenght);

                        for (int i = 0; i < inputString.Length - lastElement.Length; i += (inputString.Length - lastElement.Length) / (partitions - 1))
                        {
                            string sub = inputString.Substring(i, (inputString.Length - lastElement.Length) / (partitions - 1));
                            sack.Add(sub);
                        }
                        sack.Add(lastElement);
                        isModified = true;
                    }
                    
                }

                if (isModified)
                {
                    inputLine.RemoveAt(index);
                }
                
                inputLine.InsertRange(index, sack);
            }

        }

        static int MakeSureIsInRange(int index, int listCount)
        {
            if (index < 0)
            {
                index = 0;
            }
            if (index > listCount - 1)
            {
                index = listCount - 1;
            }

            return index;
        }

        static void MergeList(List<string> inputLine, int startIndex, int endIndex)
        {
            for (int i = 0; i < endIndex - startIndex; i++)
            {

                var temp = new StringBuilder();
                temp.Append(inputLine[startIndex] + inputLine[startIndex + 1]);
                inputLine.RemoveRange(startIndex, 2);
                inputLine.Insert(startIndex, temp.ToString());
            }
        }
    }
}

