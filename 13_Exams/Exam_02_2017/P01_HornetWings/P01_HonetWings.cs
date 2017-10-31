using System;


namespace P01_HornetWings
{
    class P01_HonetWings
    {
        static void Main()
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            decimal distPerFlaps = decimal.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            var distance = wingFlaps / 1000 * distPerFlaps;

            var time = wingFlaps / 100 + wingFlaps / endurance * 5;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{time} s.");

        }
    }
}
