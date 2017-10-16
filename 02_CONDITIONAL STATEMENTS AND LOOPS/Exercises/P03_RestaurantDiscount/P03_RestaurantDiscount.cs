using System;

namespace P03_RestaurantDiscount
{
    class P03_RestaurantDiscount
    {
        static void Main()
        {
            
            int numberOfPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double smallHallPrice = 2500.0;
            double terracePrice = 5000.0;
            double greatHallPrice = 7500.0;

            double normalPrice = 500.0;
            double goldPrice = 750.0;
            double platinumPrice = 1000.0;

            string hallType = "unknown";

            double pricePerPerson = 0;

            if (numberOfPeople >120)
            {
                Console.WriteLine("We do not have an appropriate hall."); 
            }

            else
            {
                if (numberOfPeople <= 50)
                {
                    hallType = "Small Hall";

                    if (package == "Normal")
                    {
                        pricePerPerson = (smallHallPrice + normalPrice) * 0.95 / numberOfPeople;
                    }

                    else if (package == "Gold")
                    {
                        pricePerPerson = (smallHallPrice + goldPrice) * 0.90 / numberOfPeople;
                    }

                    else if (package == "Platinum")
                    {
                        pricePerPerson = (smallHallPrice + platinumPrice) * 0.85 / numberOfPeople;
                    }
                }

                else if (numberOfPeople > 50 && numberOfPeople <= 100)
                {
                    hallType = "Terrace";

                    if (package == "Normal")
                    {
                        pricePerPerson = (terracePrice + normalPrice) * 0.95 / numberOfPeople;
                    }

                    else if (package == "Gold")
                    {
                        pricePerPerson = (terracePrice + goldPrice) * 0.90 / numberOfPeople;
                    }

                    else if (package == "Platinum")
                    {
                        pricePerPerson = (terracePrice + platinumPrice) * 0.85 / numberOfPeople;
                    }
                }


                else if (numberOfPeople > 100 && numberOfPeople <= 120)
                {
                    hallType = "Great Hall ";

                    if (package == "Normal")
                    {
                        pricePerPerson = (greatHallPrice + normalPrice) * 0.95 / numberOfPeople;
                    }

                    else if (package == "Gold")
                    {
                        pricePerPerson = (greatHallPrice + goldPrice) * 0.90 / numberOfPeople;
                    }

                    else if (package == "Platinum")
                    {
                        pricePerPerson = (greatHallPrice + platinumPrice) * 0.85 / numberOfPeople;
                    }
                }

                Console.WriteLine($"We can offer you the {hallType}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }

        }
    }
}
