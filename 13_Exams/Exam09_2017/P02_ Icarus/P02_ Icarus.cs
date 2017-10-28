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

                if (direction == "left")
                {
                    for (int i = initialPosition; i > initialPosition - steps; i--)
                    {
                        inputList[i - 1] = inputList[i - 1] - damage;
                        
                    }
                    initialPosition = initialPosition-steps;

                }

                else
                {
                    

                }

              
                moves = Console.ReadLine();
            }


            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
