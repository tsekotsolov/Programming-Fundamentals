using System;

namespace P01_SweetDesserts
{
    class P01_SweetDesserts
    {
        static void Main()
        {
            decimal cash, cashNeeded;

            ReadInput(out cash, out cashNeeded);

            PrintResults(cash, cashNeeded);

        }
        private static void ReadInput(out decimal cash, out decimal cashNeeded)
        {
            cash = decimal.Parse(Console.ReadLine());
            long guests = long.Parse(Console.ReadLine());

            decimal bananaPrice = decimal.Parse(Console.ReadLine());

            decimal eggPrice = decimal.Parse(Console.ReadLine());

            decimal berryPricePerKilo = decimal.Parse(Console.ReadLine());

            var setOfSixPrice = 2 * bananaPrice + 4 * eggPrice + 0.2M * berryPricePerKilo;

            var setsNeeded = Math.Ceiling(guests / 6.0M);

            cashNeeded = setsNeeded * setOfSixPrice;
        }

        private static void PrintResults(decimal cash, decimal cashNeeded)
        {
            if (cashNeeded <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {cashNeeded:f2}lv.");
            }

            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {cashNeeded - cash:f2}lv more.");
            }
        }

       
    }
}
