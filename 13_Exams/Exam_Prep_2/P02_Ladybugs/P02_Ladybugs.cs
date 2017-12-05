using System;
using System.Collections.Generic;
using System.Linq;


namespace P02_Ladybugs
{
    class P02_Ladybugs
    {
        static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var bugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> field = CreateField(fieldSize, bugIndexes);

            var command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                var startIndex = int.Parse(command[0]);
                var direction = command[1];
                var flightLenght = int.Parse(command[2]);

                if (startIndex < 0 || startIndex > field.Count - 1)
                {
                    command = Console.ReadLine().Split().ToArray();
                    continue;
                }

                if (flightLenght < 0)
                {
                    flightLenght = Math.Abs(flightLenght);
                    direction = ReverseDirection(direction);

                }

                if (field[startIndex] == 1 && direction == "right")
                {
                    startIndex = MoveRight(field, startIndex, flightLenght);

                }


                else if (field[startIndex] == 1 && direction == "left")
                {
                    startIndex = MoveLeft(field, startIndex, flightLenght);

                }

                command = Console.ReadLine().Split().ToArray();
            }


            Console.WriteLine(string.Join(" ", field));

        }

        private static int MoveLeft(List<int> field, int startIndex, int flightLenght)
        {
            field[startIndex] = 0;

            while (true)
            {
                if (startIndex - flightLenght >= 0)
                {
                    if (field[startIndex - flightLenght] == 1)
                    {
                        startIndex -= flightLenght;
                    }
                    else
                    {
                        field[startIndex - flightLenght] = 1;
                        break;
                    }

                }

                else
                {
                    break;
                }
            }

            return startIndex;
        }

        private static int MoveRight(List<int> field, int startIndex, int flightLenght)
        {
            field[startIndex] = 0;

            while (true)
            {
                if (startIndex + flightLenght <= field.Count - 1)
                {
                    if (field[startIndex + flightLenght] == 1)
                    {
                        startIndex += flightLenght;
                    }
                    else
                    {
                        field[startIndex + flightLenght] = 1;
                        break;
                    }
                }

                else
                {
                    break;
                }
            }

            return startIndex;
        }

        private static string ReverseDirection(string direction)
        {
            if (direction == "right")
            {
                direction = "left";
            }
            else if (direction == "left")
            {
                direction = "right";
            }

            return direction;
        }

        private static List<int> CreateField(int fieldSize, int[] bugIndexes)
        {
            var field = new List<int>(fieldSize);

            for (int i = 0; i < field.Capacity; i++)
            {
                field.Add(0);
            }

            for (int i = 0; i < field.Count; i++)
            {
                if (bugIndexes.Contains(i))
                {
                    field[i] = 1;
                }
            }

            return field;
        }
    }
}
