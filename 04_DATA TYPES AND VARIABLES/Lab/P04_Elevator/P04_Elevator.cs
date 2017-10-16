using System;

namespace P04_Elevator
{
    class P04_Elevator
    {
        static void Main()
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling((double)persons/capacity));


        }
    }
}
