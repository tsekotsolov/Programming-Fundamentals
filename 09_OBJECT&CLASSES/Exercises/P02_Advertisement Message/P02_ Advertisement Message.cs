using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Advertisement_Message
{
    class Program
    {
        static void Main()
        {
            int messageCount = int.Parse(Console.ReadLine());

            string[] phrases = new string[]
                {"Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product." };


            string[] events = new string[]

                 { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

            string[] authors = new string[]
                {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            string[] cities = new string[]
                {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            Random rnd = new Random();

            int phraseIndex;
            int eventsIndex;
            int authorsIndex;
            int citiesIndex;

            

            for (int i = 0; i < messageCount; i++)
            {

                phraseIndex = rnd.Next(phrases.Length);
                eventsIndex = rnd.Next(events.Length);
                authorsIndex = rnd.Next(authors.Length);
                citiesIndex = rnd.Next(cities.Length);
                Console.WriteLine($"{phrases[phraseIndex]} {events[eventsIndex]} {authors[authorsIndex]} - {cities[citiesIndex]}");
            }

        }
    }
}
