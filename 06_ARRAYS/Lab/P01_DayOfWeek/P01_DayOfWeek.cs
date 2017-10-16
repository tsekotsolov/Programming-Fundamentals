using System;

namespace P01_DayOfWeek
{
    class P01_DayOfWeek
    {
        static void Main()
        {

            int dayOfWeek = int.Parse(Console.ReadLine());

            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            if (dayOfWeek>=1 && dayOfWeek<=7)
            {
                Console.WriteLine(days[dayOfWeek-1]);
            }

            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
