using System;


namespace P08_CaloriesCounter
{
    class P08_CaloriesCounter
    {
        static void Main()
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            
            int calsCounter = 0;

            for (int i = 0; i < numberOfIngredients; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if (ingredient=="cheese")
                {
                    calsCounter+=500;
                }
                else if (ingredient == "tomato sauce")
                {
                    calsCounter += 150;
                }
                else if (ingredient == "salami")
                {
                    calsCounter += 600;
                }

                else if (ingredient == "pepper")
                {
                    calsCounter += 50;
                }
            }
            Console.WriteLine($"Total calories: {calsCounter}");
        }
    }
}
