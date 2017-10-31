using System;
using System.Linq;


namespace P01_Resurrection
{
    class P01_Resurrection
    {
        static void Main()
        {
            int numberOfBirds = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBirds; i++)
            {
                long lenght = long.Parse(Console.ReadLine());
                decimal width = decimal.Parse(Console.ReadLine());
                long wing = long.Parse(Console.ReadLine());

                var delta = width - Math.Floor(width);
                var precision = 0;

                if (delta!=0)
                {
                    precision = delta.ToString().Split('.').Skip(1).ToArray().First().ToString().Length;
                }
                
                decimal years = lenght * lenght * (width + 2 * wing);

                Console.WriteLine($"{Math.Round(years,precision)}");

            }
        }
    }
}
