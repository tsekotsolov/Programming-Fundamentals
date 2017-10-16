using System;
namespace P14_MagicLetter
{
    class P14_MagicLetter
    {
        static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char k = firstLetter; k <= secondLetter; k++)
                {
                    for (char l = firstLetter; l <=secondLetter; l++)
                    {
                        if (!(i==thirdLetter || k==thirdLetter || l==thirdLetter))
                        {
                            Console.Write($"{i}{k}{l} ");
                        }
                    }
                }
            }

        }
    }
}
