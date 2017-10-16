using System;


namespace P02_Choose_ADrink_2._0
{
    class Program
    {
        static void Main()
        {
            string job = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double waterPrice = 0.70;
            double coffeePrice = 1.00;
            double beerPrice = 1.70;
            double teaPrice = 1.20;
            double totalPrice = 0;

            if (job == "Athlete")
            {
                totalPrice = quantity * waterPrice;
            }
            else if (job == "Businessman" || job == "Businesswoman")
            {
                totalPrice = quantity * coffeePrice;
            }
            else if (job == "SoftUni Student")
            {
                totalPrice = quantity * beerPrice;
            }
            else
            {
                totalPrice = quantity * teaPrice;
            }

            Console.WriteLine($"The {job} has to pay {totalPrice:f2}.");

        }
    }
    }


