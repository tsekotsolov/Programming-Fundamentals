using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_CommandInterpreter
{
    class P02_CommandInterpreter
    {

        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var instructions = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (instructions[0] == "reverse")
                {
                    var startPosition = int.Parse(instructions[2]);
                    var countElementsToReverse = int.Parse(instructions[4]);

                    if (startPosition < 0 || countElementsToReverse < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else if (startPosition > input.Count - 1)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                    else if (startPosition + countElementsToReverse - 1 > input.Count - 1)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        var reversed = input.Skip(startPosition)
                            .Take(countElementsToReverse)
                            .Reverse()
                            .ToList();

                        input.RemoveRange(startPosition, countElementsToReverse);
                        input.InsertRange(startPosition, reversed);
                    }
                }

                else if (instructions[0] == "sort")
                {
                    var startPosition = int.Parse(instructions[2]);
                    var countElementsToSort = int.Parse(instructions[4]);

                    if (startPosition < 0 || countElementsToSort < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else if (startPosition > input.Count - 1)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                    else if (startPosition + countElementsToSort - 1 > input.Count - 1)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                    else
                    {
                        //var sorted = input.Skip(startPosition)
                        //    .Take(countElementsToSort)
                        //    .OrderBy(x => x)
                        //    .ToList();
                        //input.RemoveRange(startPosition, countElementsToSort);
                        //input.InsertRange(startPosition, sorted);


                        var firstPart = input.Take(startPosition);
                        var sorted = input.Skip(firstPart.Count())
                            .Take(countElementsToSort)
                            .OrderBy(x => x).ToList();

                        var restPart = input.Skip(firstPart.Count() + sorted.Count());

                        input = (firstPart.Concat(sorted)).Concat(restPart).ToList();



                    }
                }

                else if (instructions[0] == "rollLeft")
                {
                    var timestoRollLeft = int.Parse(instructions[1]);

                    if (timestoRollLeft >= 0)
                    {
                        for (int i = 0; i < timestoRollLeft; i++)
                        {
                            //var zeroelement = input[0];
                            //input.RemoveAt(0);
                            //input.Add(zeroelement);

                            var firstPart = input.Take(1);
                            var restPart = input.Skip(1).Take(input.Count - 1);

                            input = restPart.Concat(firstPart).ToList();

                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                }

                else if (instructions[0] == "rollRight")
                {
                    var timestoRollRight = int.Parse(instructions[1]);

                    if (timestoRollRight >= 0)
                    {
                        for (int i = 0; i < timestoRollRight; i++)
                        {
                            //var lastelement = input[input.Count - 1];
                            //input.RemoveAt(input.Count - 1);
                            //input.Insert(0, lastelement);

                            var lastPart = input.Skip(input.Count-1);
                            var restPart = input.Take(input.Count-1);
                            input = lastPart.Concat(restPart).ToList();

                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }

                command = Console.ReadLine();
            }

            
            
            

            Console.WriteLine($"[{string.Join(", ", input)}]");

        }

    }

}
