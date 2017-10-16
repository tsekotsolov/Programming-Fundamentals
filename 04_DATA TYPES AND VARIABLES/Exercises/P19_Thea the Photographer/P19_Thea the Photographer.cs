using System;

namespace P19_Thea_the_Photographer
{
    class Program
    {
        static void Main()
        {
            decimal numberOfImages = decimal.Parse(Console.ReadLine());

            decimal filterTime = decimal.Parse(Console.ReadLine()); 
            decimal filterFactor = decimal.Parse(Console.ReadLine()); 
            decimal uploadTime = decimal.Parse(Console.ReadLine()); 

            decimal usefuImages = Math.Ceiling((numberOfImages * filterFactor / 100));

            decimal totalTime = filterTime * numberOfImages + usefuImages * uploadTime;

            TimeSpan t = TimeSpan.FromSeconds((Double)totalTime);

            string timeFormated = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                            t.Days,
                            t.Hours,
                            t.Minutes,
                            t.Seconds
                            );

            Console.WriteLine(timeFormated);

        }
    }
}
