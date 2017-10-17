using System;
using System.Collections.Generic;
using System.Linq;


namespace P02_Odd_Occurrences
{
    class Program
    {
        static void Main()
        {

            var sentance = Console.ReadLine()
           .ToLower()
           .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .ToList();

            var dictionary = new Dictionary<string, int>();

            foreach (var word in sentance)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary[word] = 1;
                }
            }

            var oddlist = new List<string>();

            foreach (var pair in dictionary)
            {
                if (!(pair.Value%2==0))
                {
                    oddlist.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ",oddlist));
        }
    }
}
