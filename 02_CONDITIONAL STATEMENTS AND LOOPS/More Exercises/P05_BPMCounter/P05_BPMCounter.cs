using System;

namespace P05_BPMCounter
{
    class P05_BPMCounter
    {
        static void Main()
        {
            int BPM = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());

            double seconds = beats * 60.0 / BPM;
            int minutes = (int)seconds / 60;
            seconds -= minutes * 60;

            Console.Write($"{Math.Round(beats / 4.0, 1) } bars - ");
            Console.WriteLine($"{minutes}m {Math.Floor(seconds)}s");
        }
    }
}
