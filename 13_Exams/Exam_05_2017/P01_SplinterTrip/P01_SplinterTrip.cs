using System;


namespace P01_SplinterTrip
{
    class P01_SplinterTrip
    {
        static void Main()
        {
            decimal distance = decimal.Parse(Console.ReadLine());
            decimal fuelLoaded = decimal.Parse(Console.ReadLine());
            decimal milesInWinds = decimal.Parse(Console.ReadLine());

            var fuelNeeded = ((milesInWinds * 25 * 1.5m) 
                + (distance - milesInWinds) * 25) * 1.05m;

            Console.WriteLine($"Fuel needed: {fuelNeeded:f2}L");

            if (fuelLoaded>=fuelNeeded)
            {
                Console.WriteLine($"Enough with {(fuelLoaded-fuelNeeded):f2}L to spare!");
            }

            else
            {
                Console.WriteLine($"We need {(fuelNeeded - fuelLoaded):f2}L more fuel.");
            }

        }
    }
}
