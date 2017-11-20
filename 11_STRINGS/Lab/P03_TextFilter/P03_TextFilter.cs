using System;
using System.Linq;

namespace P03_TextFilter
{
    class P03_TextFilter
    {
        static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }

            }

            Console.WriteLine(text);
        }
    }
}
