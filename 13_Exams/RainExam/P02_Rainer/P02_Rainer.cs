using System;
using System.Collections.Generic;
using System.Linq;


namespace P02_Rainer
{
    class P02_Rainer
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var initialIndex = input.Skip(input.Count - 1).Take(1).ToList().First();

            var gameField = input.Take(input.Count - 1).ToList();

            var counter = 0;

            bool isWet = false;


            var original = new List<int>();

            for (int i = 0; i < gameField.Count; i++)
            {
                original.Add(gameField[i]);
            }


            while (true)
            {

                for (int i = 0; i < gameField.Count; i++)
                {
                    gameField[i] -= 1;
                }


                for (int i = 0; i < gameField.Count; i++)
                {

                    if (gameField[i] == 0 && i == initialIndex)
                    {
                        isWet = true;
                        break;
                    }
                }


                if (isWet)
                {
                    break;
                }

                for (int i = 0; i < gameField.Count; i++)
                {
                    if (gameField[i] == 0 && i != initialIndex)
                    {
                        gameField[i] = original[i];
                    }
                }

                    initialIndex = int.Parse(Console.ReadLine());
                    counter++;               
            }

            Console.WriteLine(string.Join(" ", gameField));

            Console.WriteLine(counter);
        }
    }
}
