using System;


namespace _06TheatrePromotion
{
    class TheatrePromotion
    {
        static void Main()
        {
            string typeOfDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int price=0;

            if (age > 122 || age < 0)
            {
                Console.WriteLine("Error!");
            }

            else
            {
                if (typeOfDay == "weekday" && ((age >= 0 && age <= 18) || (age > 64 && age <= 122)))
                {

                    price = 12;
                }

                if (typeOfDay == "weekday" && (age > 18 && age <= 64))
                {

                    price = 18;
                }

                if (typeOfDay == "weekend" && ((age >= 0 && age <= 18) || (age > 64 && age <= 122)))
                {

                    price = 15;
                }

                if (typeOfDay == "weekend" && (age > 18 && age <= 64))
                {

                    price = 20;
                }

                if (typeOfDay == "holiday" && (age >= 0 && age <= 18))
                {

                    price = 5;
                }

                if (typeOfDay == "holiday" && (age > 18 && age <= 64))
                {

                    price = 12;
                }

                if (typeOfDay == "holiday" && (age > 64 && age <= 122))
                {

                    price = 10;
                }

            }

            Console.WriteLine($"{price}$");

        }
    }
}
