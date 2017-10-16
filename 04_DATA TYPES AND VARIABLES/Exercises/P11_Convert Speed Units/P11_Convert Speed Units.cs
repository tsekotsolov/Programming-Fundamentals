using System;

namespace P11_Convert_Speed_Units
{
    class Program
    {
        static void Main()
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float timeInSeconds = hours * 3600 + minutes * 60 + seconds;
            float timeInHours = timeInSeconds / 3600;

            Console.WriteLine(distance / timeInSeconds);
            Console.WriteLine(distance / 1000 / timeInHours);
            Console.WriteLine(distance / 1609 / timeInHours);
        }
    }
}
