using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Change_List
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
           .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToList();

            while (true)
            {

                var command = Console.ReadLine()
                    .ToLower()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (command[0] == "delete")
                {
                    int value = int.Parse(command[1]);

                    while (numbers.Contains(value))
                    {
                        numbers.Remove(value);
                    }
                }

                if (command[0] == "insert")
                {

                    int elementValue = int.Parse(command[1]);
                    int elementPosition = int.Parse(command[2]);

                    numbers.Insert(elementPosition, elementValue);

                }

                if (command[0] == "even")
                {
                    var evenList = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {

                            evenList.Add(numbers[i]);
                        }
                    }

                    Console.WriteLine(string.Join(" ", evenList));
                    break;
                }

                if (command[0] == "odd")
                {
                    var oddList = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {

                            oddList.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", oddList));
                    break;
                }

            }

        }
    }
}
