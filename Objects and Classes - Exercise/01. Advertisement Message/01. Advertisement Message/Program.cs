using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };
            List<string> events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            List<string> authors = new List<string>
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            List<string> cities = new List<string>
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            int messagesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < messagesCount; i++)
            {
                Random random = new Random();
                int phrasesRandomIndex = random.Next(0, phrases.Count);
                int eventsRandomIndex = random.Next(0, events.Count);
                int authorsRandomIndex = random.Next(0, authors.Count);
                int citiesRandomIndex = random.Next(0, cities.Count);

                Console.WriteLine($"{phrases[phrasesRandomIndex]} {events[eventsRandomIndex]} {authors[authorsRandomIndex]} – {cities[citiesRandomIndex]}.");
            }
        }
    }
}
