using System;
namespace P06_DNASequences
{
    class P06_DNASequences
    {
        enum nucs
        {
            A = 1, C = 2, G = 3, T = 4
        }
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            int counterNewLine = 0;

            for (nucs i = nucs.A; i <= nucs.T; i++)
            {

                for (nucs k = nucs.A; k <= nucs.T; k++)
                {
                    for (nucs l = nucs.A; l <= nucs.T; l++)
                    {
                        counterNewLine++;


                        if ((int)i + (int)k + (int)l >= sum)
                        {
                            Console.Write($"O{i}{k}{l}O ");
                        }

                        else
                        {
                            Console.Write($"X{i}{k}{l}X ");
                        }
                        
                    }

                    Console.WriteLine();
                }
            }

        }
    }
}
