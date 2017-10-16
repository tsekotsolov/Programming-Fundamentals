using System;


namespace P07_CakeIngredients
{
    class P07_CakeIngredients
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (true)
            {
                string ingredient = Console.ReadLine();

                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    break;

                }
                Console.WriteLine($"Adding ingredient {ingredient}." );
                counter++;
                
            } 
        }
    }
}
