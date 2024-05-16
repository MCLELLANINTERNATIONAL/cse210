using System;

class Program
{
    static void Main(string[] args)
    {   
        var choice = "";
        do
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Select a Menu Option:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start listing activity");
            Console.WriteLine(" 3. Start reflecting activity");
            Console.WriteLine(" 4. Quite");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice == "3")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Invalid Choice. Try Again!");
            }
        }
        while(choice !="4");
    }
}

