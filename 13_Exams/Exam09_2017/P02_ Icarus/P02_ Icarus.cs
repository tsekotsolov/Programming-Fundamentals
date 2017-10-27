using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02__Icarus
{
    class Program
    {
        static void Main()
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int initialPosition = int.Parse(Console.ReadLine());
            int damage = 1;

            var moves = Console.ReadLine();
            while (moves != "Supernova")
            {
                var movesSplited = moves.Split(' ').ToArray();

                var direction = movesSplited.First();
                var steps = int.Parse(movesSplited[1]);


                for (int i = initialPosition; i < inputList.Count; i++)
                {
                    if (direction=="left")
                    {
                        inputList[i - steps] = inputList[i - steps] - damage;
                        initialPosition -= steps;
                        break;
                    }

                    if (direction == "right")
                    {
                        inputList[i + steps] = inputList[i + steps] - damage;
                        initialPosition += steps;
                        break;
                    }

                }

                moves = Console.ReadLine();
            }


            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
