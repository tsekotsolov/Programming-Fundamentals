using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_MagicExchangeableWords
{
    class P05_MagicExchangeableWords
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();

            var firstWord = input[0];
            var secondWord = input[1];

            var cycleItterantions = Math.Min(firstWord.Length, secondWord.Length);
            var isMagic = "true";
            var checkDict = new Dictionary<char, char>();

            if (firstWord.Length < secondWord.Length)
            {
                var temp = secondWord;
                secondWord = firstWord;
                firstWord = temp;
            }

            for (int i = 0; i < cycleItterantions; i++)
            {
                if (!checkDict.ContainsKey(firstWord[i]))
                {
                    checkDict.Add(firstWord[i], secondWord[i]);
                }

                else
                {
                    if (checkDict[firstWord[i]] != secondWord[i])
                    {
                        isMagic = "false";
                        Console.WriteLine(isMagic);
                        return;
                    }
                }
            }

            if (firstWord.Length != secondWord.Length)
            {
                var remainingWord = firstWord.Substring(secondWord.Length);

                for (int i = 0; i < remainingWord.Length; i++)
                {
                    if (!checkDict.ContainsKey(remainingWord[i]))
                    {
                        isMagic = "false";
                    }
                }
            }

            Console.WriteLine(isMagic);
        }
    }
}
