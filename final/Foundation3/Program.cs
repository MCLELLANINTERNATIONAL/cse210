using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
       Event[] events = new Event[]
        {
            new Lecture("Astrophysics 101", "Explore the stars!", new DateTime(2024, 5, 15), new TimeSpan(18, 0, 0), new Address("123 Galaxy St", "SpaceTown", "Universe", "USA", "00001"), "Dr. Cosmos", 100),
            new Reception("Annual Charity Ball", "A night of elegance and giving.", new DateTime(2024, 6, 20), new TimeSpan(19, 30, 0), new Address("1000 Mountain Drive", "Gotham", "NY", "USA", "11001"), "rsvp@charityball.com"),
            new OutdoorGathering("Beach Volleyball", "Fun in the sun with a chance of rain.", new DateTime(2024, 7, 12), new TimeSpan(10, 0, 0), new Address("555 Ocean Blvd", "Sunnyville", "CA", "USA", "90210"), "Sunny with occasional clouds")
        };

        foreach (Event evt in events)
        {
            // Print Standard Details
            Console.WriteLine("\nStandard Details:");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine(); // Adding a blank line for better readability

            // Print Full Details
            Console.WriteLine("Full Details:");
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine(); // Adding a blank line for better readability

            // Print Short Description
            Console.WriteLine("Short Description:");
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine("-----------------------"); // Separator for each event
        }
    }
} 