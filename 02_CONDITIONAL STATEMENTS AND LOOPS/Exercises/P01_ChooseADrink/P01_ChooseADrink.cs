using System;


namespace P01_ChooseADrink
{
    class P01_ChooseADrink
    {
        static void Main()
        {
            string job = Console.ReadLine().ToLower();

            if (job=="athlete")
            {
                Console.WriteLine("Water");
            }
            else if (job == "businessman" || job== "businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (job == "softuni student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }

        }
    }
}
