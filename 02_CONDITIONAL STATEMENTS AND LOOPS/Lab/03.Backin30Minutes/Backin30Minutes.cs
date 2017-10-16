using System;
namespace _03.Backin30Minutes
{
    class Backin30Minutes
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes+30>=60)
  
            {
                hours++;
                minutes = minutes - 30;

                if (hours>=24)
                {
                    hours = 0;
                }
            }

            else
            {
                minutes = minutes + 30;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
