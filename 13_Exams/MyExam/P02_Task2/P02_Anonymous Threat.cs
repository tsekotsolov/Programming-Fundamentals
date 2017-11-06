using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

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

                    if (inputLine.Count == 1)
                    {
                        commandSequence = Console.ReadLine().Split().ToArray();
                        continue;
                    }

                    else if (startIndex < inputLine.Count - 1 && endIndex <= inputLine.Count - 1)
                    {
                        for (int i = 0; i < endIndex - startIndex; i++)
                        {

                            var temp = new StringBuilder();
                            temp.Append(inputLine[startIndex] + inputLine[startIndex + 1]);
                            inputLine.RemoveRange(startIndex, 2);
                            inputLine.Insert(startIndex, temp.ToString());
                        }
                    }

                    else
                    {
                        for (int i = 0; i < inputLine.Count; i++)
                        {
                            var temp = new StringBuilder();
                            temp.Append(inputLine[i] + inputLine[i + 1]);
                            inputLine.RemoveRange(0, 2);
                            inputLine.Insert(0, temp.ToString());
                        }
                    }

                }

                else if (commandSequence[0] == "divide")
                {

                }

                commandSequence = Console.ReadLine().Split().ToArray();


            }


            Console.WriteLine(string.Join(" ", inputLine));

        }

    }


}

