using System;

namespace P01_Pokemon
{
    class Pokemon
    {
        static void Main()
        {
            long nPower = long.Parse(Console.ReadLine());
            long M = long.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            var pokedTargets = 0;
            var originalValue = nPower;

            while (nPower>=M)
            {
                nPower = nPower - M;
                pokedTargets++;

                if (nPower*2==originalValue && Y!=0)
                {
                    nPower = nPower / Y;
                }
            }
            Console.WriteLine(nPower);
            Console.WriteLine(pokedTargets);
        }
    }
}
