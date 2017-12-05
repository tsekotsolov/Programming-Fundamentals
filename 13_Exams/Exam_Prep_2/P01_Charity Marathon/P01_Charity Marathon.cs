using System;


namespace P01_Charity_Marathon
{
    class Program
    {
        static void Main()
        {
            var marathonDuration = short.Parse(Console.ReadLine()); 
            var numberOfParticipants = long.Parse(Console.ReadLine());
            var averageLapsPerParticipant =byte.Parse(Console.ReadLine());
            var lenghtOfTrack = int.Parse(Console.ReadLine());
            var capacityOfTrackPerDay = short.Parse(Console.ReadLine());
            decimal cashperKilometer = decimal.Parse(Console.ReadLine());



            if (numberOfParticipants > capacityOfTrackPerDay * marathonDuration)
            {
                numberOfParticipants = capacityOfTrackPerDay*marathonDuration;
            }

            long totalKiloMeters = numberOfParticipants * averageLapsPerParticipant * lenghtOfTrack / 1000;
            var moneyRaised = totalKiloMeters * cashperKilometer;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");


        }
    }
}
