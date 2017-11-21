using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_GiftRandomizer
{
    static class P05_GiftRandomizer
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>();
            List<string> randomNamesList = new List<string>();

            var names = Console.ReadLine();


            while (names != "end")
            {

                namesList.Add(names);
                randomNamesList.Add(names);
                names = Console.ReadLine();
            }

            randomNamesList.Shuffle();
            namesList.Shuffle();

            var dict = new Dictionary<string, string>();

            for (int i = 0; i < namesList.Count; i++)
            {
                if (namesList[i] != randomNamesList[i])
                {
                    dict.Add(namesList[i], randomNamesList[i]);
                }
            }

            foreach (var person in dict)
            {
                Console.WriteLine($"{person.Key}-{person.Value}");
            }
        }
        public static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
