namespace _007AdvertisementMessage
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int n = int.Parse(Console.ReadLine());
            List<string> phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> author = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                int rndPhrase = rnd.Next(phrases.Count);
                int rndEvents = rnd.Next(events.Count);
                int rndAuthor = rnd.Next(author.Count);
                int rndCities = rnd.Next(cities.Count);
                Console.WriteLine("{0} {1} {2} - {3}", phrases[rndPhrase], events[rndEvents], author[rndAuthor], cities[rndCities]);
            }
        }
    }
}