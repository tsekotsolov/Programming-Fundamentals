using System;
using System.Globalization;

namespace P01_CoffeeOrders
{
    class P01_CoffeeOrders
    {
        static void Main()
        {
            int ordersCount = int.Parse(Console.ReadLine());
            var totalPrice = 0.0M;

            for (int i = 0; i < ordersCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsules = long.Parse(Console.ReadLine());

                var daysInMonth = System.DateTime.DaysInMonth(date.Year,date.Month);

                var price = daysInMonth * capsules * pricePerCapsule;

                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");


            }
            Console.WriteLine($"Total: ${totalPrice:f2}");


        }
    }
}
