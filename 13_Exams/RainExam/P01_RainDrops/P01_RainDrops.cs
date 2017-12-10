using System;
using System.Linq;


namespace P01_RainDrops
{
    class P01_RainDrops
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var density = double.Parse(Console.ReadLine());

            double sumOfRegionalCoeficients = 0.0;

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split().ToArray();

                var rainDropsCount = double.Parse(inputLine[0]);

                var squareMeters = double.Parse(inputLine[1]);

                var regionalCoef = rainDropsCount / squareMeters;

                sumOfRegionalCoeficients += regionalCoef;
            }

            if (density!=0)
            {
                var result = sumOfRegionalCoeficients / density;


                Console.WriteLine($"{result:f3}");
            }

            else
            {
                Console.WriteLine($"{sumOfRegionalCoeficients:f3}");
            }

            

        }
    }
}
