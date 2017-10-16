using System;

namespace P07_TrainingHallEquipment
{
    class P07_TrainingHallEquipment
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            double budgetNeeded = 0;

            for (int i = 0; i < numberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                if (itemCount>1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }

                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }

                budgetNeeded += itemCount * itemPrice; 

            }
            Console.WriteLine($"Subtotal: ${budgetNeeded:f2}");

            if (budget>=budgetNeeded)
            {
                Console.WriteLine($"Money left: ${(budget-budgetNeeded):f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${(budgetNeeded-budget):f2} more.");
            }
        }
    }
}
