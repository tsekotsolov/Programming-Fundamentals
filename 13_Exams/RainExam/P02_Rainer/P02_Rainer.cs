using System;
using System.Collections.Generic;
using System.Linq;


namespace P02_Rainer
{
    class P02_Rainer
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToList();

            var initialIndex = input.Skip(input.Count - 1).Take(1).ToList().First();

            var gameField = input.Take(input.Count - 1).ToList();

            var counter = -1;

            bool breaker = true;


            var original = new List<long>();

            for (int i = 0; i < gameField.Count; i++)
            {
                original.Add(gameField[i]);
            }


            while (breaker)
            {

                for (int i = 0; i < gameField.Count; i++)
                {
                    gameField[i] -= 1;
                }


                for (int i = 0; i < gameField.Count; i++)
                {

                    if (gameField[i] == 0 && i == initialIndex)
                    {
                        breaker = false;
                        break;

                    }
                    else if (gameField[i] == 0 && i != initialIndex)
                    {
                        gameField[i] = original[i];
                    }

                }

                

                if (breaker)
                {
                    initialIndex = long.Parse(Console.ReadLine());
                }

                counter++;
            }


            Console.WriteLine(string.Join(" ", gameField));

            Console.WriteLine(counter);
        }
    }
}
