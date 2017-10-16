using System;

namespace _07.Divisibleby3
{
    class Divisibleby3
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <= 99; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
