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
            int indexPosition = int.Parse(Console.ReadLine());
            int damage = 1;
            


            var moves = Console.ReadLine();
            while (moves != "Supernova")
            {
                var movesSplited = moves.Split(' ').ToArray();
                var direction = movesSplited.First();
                var steps = int.Parse(movesSplited[1]);

                if (direction == "left" && steps != 0)
                {

                    for (int i = 1; i <= steps; i++)
                    {
                        if (indexPosition <= 0)
                        {
                            damage++;
                            indexPosition = inputList.Count;
                            
                        }

                        inputList[indexPosition - 1] = inputList[indexPosition - 1] - damage;

                        indexPosition--;

                    }

                }

                else if (direction == "right" && steps != 0)
                {

                    for (int i = 1; i <= steps; i++)
                    {

                        if (indexPosition >= inputList.Count-1)
                        {
                            damage++;
                            indexPosition = -1;
                           
                        }

                        inputList[indexPosition + 1] = inputList[indexPosition + 1] - damage;
                        indexPosition++;

                    }
                }

                else
                {
                    moves = Console.ReadLine();
                    continue;
                }


                moves = Console.ReadLine();
            }


            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
