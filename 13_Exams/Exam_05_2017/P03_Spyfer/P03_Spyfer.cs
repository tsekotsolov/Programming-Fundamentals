using System;
using System.Linq;


namespace P03_Spyfer
{
    class P03_Spyfer
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < inputLine.Count; i++)
            {

                if (i != 0 && i != inputLine.Count - 1)
                {
                    if (inputLine[i] == inputLine[i - 1] + inputLine[i + 1])
                    {
                        inputLine.RemoveAt(i + 1);
                        inputLine.RemoveAt(i - 1);
                        i = 0;
                    }
                }

                else if (i == 0 && inputLine[i] == inputLine[i + 1])
                {
                    inputLine.RemoveAt(i + 1);
                    i = 0;
                }

                else if (i == inputLine.Count - 1 && inputLine[i] == inputLine[i - 1])
                {
                    inputLine.RemoveAt(i - 1);
                    i = 0;
                }

            }
            Console.WriteLine(string.Join(" ", inputLine));

        }
    }
}
