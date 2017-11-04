using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_PokemonDoNotGo
{
    class P02_PokemonDoNotGo
    {
        static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var sumOfTheRemoved = 0;

            while (inputLine.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                var removed = 0;

                if (index < 0)
                {

                    sumOfTheRemoved += inputLine[0];
                    removed = inputLine[0];
                    inputLine.RemoveAt(0);

                    if (inputLine.Count >= 1)
                    {

                        inputLine.Insert(0, inputLine[inputLine.Count - 1]);
                    }

                }

                else if (index > inputLine.Count - 1)
                {

                    sumOfTheRemoved += inputLine[inputLine.Count - 1];
                    removed = inputLine[inputLine.Count - 1];
                    inputLine.RemoveAt(inputLine.Count - 1);

                    if (inputLine.Count >= 1)
                    {
                        inputLine.Add(inputLine[0]);
                    }

                }
                else
                {
                    sumOfTheRemoved += inputLine[index];
                    removed = inputLine[index];
                    inputLine.RemoveAt(index);

                }

                for (int i = 0; i < inputLine.Count; i++)
                {
                    if (inputLine[i] <= removed)
                    {
                        inputLine[i] += removed;
                    }
                    else
                    {
                        inputLine[i] -= removed;
                    }
                }
            }
            Console.WriteLine(sumOfTheRemoved);
        }
    }
}
