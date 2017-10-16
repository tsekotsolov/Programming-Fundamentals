using System;


namespace P13_GameofNumbers
{
    class P13_GameofNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int lastFirstNum = 0;
            int lastSecondNum = 0;


            int combinationCounter = 0;

            for (int i = n; i <= m; i++)
            {
                for (int k = n; k <= m; k++)
                {
                    combinationCounter++;
                    
                    if (i+k == magicNumber)
                    {
                        
                        lastFirstNum = i;
                        lastSecondNum = k;
                    }
                }
            }

            if (lastFirstNum+lastSecondNum==magicNumber)
            {
                Console.WriteLine($"Number found! {lastFirstNum} + {lastSecondNum} = {magicNumber}");
            }

            else
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");
            }

        }
    }
}
