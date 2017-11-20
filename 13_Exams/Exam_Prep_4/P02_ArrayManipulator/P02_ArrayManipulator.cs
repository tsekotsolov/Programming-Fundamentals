using System;
using System.Collections.Generic;
using System.Linq;


namespace P02_ArrayManipulator
{
    class P02_ArrayManipulator
    {
        static void Main()
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine().Split().ToList();

            while (command[0]!="end")
            {

                switch (command[0])
                {

                    case "exchange":

                        inputList = Exchange(inputList, command);
                        break;

                    case "max":

                        int indexPostion = FindMaxIndex(inputList, command[1]);
                        PrintIndexPosition(indexPostion);
                        break;

                    case "min":

                        indexPostion = FindMinIndex(inputList, command[1]);

                        PrintIndexPosition(indexPostion);
                        break;

                    case "first":

                        PrintFirstElements(inputList, command);
                        break;

                    case "last":

                        PrintLastElements(inputList, command);
                        break;
                        
                }
                command = Console.ReadLine().Split().ToList();

            }

            Console.WriteLine($"[{string.Join(", ", inputList)}]");
        }

        private static void PrintFirstElements(List<int> inputList, List<string> command)
        {
            var count = int.Parse(command[1]);

            if (count > inputList.Count)
            {
                Console.WriteLine("Invalid count");
            }

            else
            {
                var resultList = CreateEvenOrOddList(inputList, command[2]);

                if (resultList.Count > count)
                {
                    resultList = resultList.Take(count).ToList();
                }

                Console.WriteLine($"[{string.Join(", ", resultList)}]");

            }
        }

        private static void PrintLastElements(List<int> inputList, List<string> command)
        {
            var count = int.Parse(command[1]);

            if (count > inputList.Count)
            {
                Console.WriteLine("Invalid count");
            }

            else
            {
                var resultList = CreateEvenOrOddList(inputList, command[2]);

                if (resultList.Count > count)
                {
                    resultList = resultList.Skip(resultList.Count - count).ToList();
                }

                Console.WriteLine($"[{string.Join(", ", resultList)}]");

            }
        }

        private static void PrintIndexPosition(int indexPostion)
        {
            if (indexPostion != -1)
            {
                Console.WriteLine(indexPostion);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static int FindMinIndex(List<int> inputList, string valueType)
        {
            var minOddValue = int.MaxValue;
            var minEvenValue = int.MaxValue;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 != 0 && inputList[i] <= minOddValue)
                {
                    minOddValue = inputList[i];
                }

                else if (inputList[i] % 2 == 0 && inputList[i] <= minEvenValue)
                {
                    minEvenValue = inputList[i];
                }
            }

            if (valueType == "odd")
            {
                var minOddIndex = inputList.LastIndexOf(minOddValue);
                return minOddIndex;
            }
            else
            {
                var minEvenIndex = inputList.LastIndexOf(minEvenValue);
                return minEvenIndex;
            }
        }

        private static int FindMaxIndex(List<int> inputList, string valueType)
        {
            var maxOddValue = int.MinValue;
            var maxEvenValue = int.MinValue;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 != 0 && inputList[i] >= maxOddValue)
                {
                    maxOddValue = inputList[i];
                }

                else if (inputList[i] % 2 == 0 && inputList[i] >= maxEvenValue)
                {
                    maxEvenValue = inputList[i];
                }
            }

            if (valueType == "odd")
            {
                var maxOddIndex = inputList.LastIndexOf(maxOddValue);
                return maxOddIndex;
            }
            else
            {
                var maxEvenIndex = inputList.LastIndexOf(maxEvenValue);
                return maxEvenIndex;
            }

        }

        private static List<int> Exchange(List<int> inputList, List<string> command)
        {
            var index = int.Parse(command[1]);
            bool isInside = index >= 0 && index < inputList.Count;
            if (isInside)
            {
                var firstPart = inputList.Take(index + 1);
                var secondPart = inputList.Skip(index + 1);
                inputList = secondPart.Concat(firstPart).ToList();
            }

            else
            {
                Console.WriteLine("Invalid index");
            }

            return inputList;
        }

        private static List<int> CreateEvenOrOddList(List<int> inputList, string valueType)
        {
            if (valueType == "odd")
            {
                var oddList = inputList.Where(x => x % 2 != 0).ToList();

                return oddList;

            }

            else
            {
                var evenList = inputList.Where(x => x % 2 == 0).ToList();

                return evenList;
            }
        }
    }
}
