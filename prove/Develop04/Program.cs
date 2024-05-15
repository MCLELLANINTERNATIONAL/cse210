using System;

class Program
{
    static void Main(string[] args)
    {   
        var choice = "";
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflectig activity");
            Console.WriteLine(" 3. Start reflecting activity");
            Console.WriteLine(" 4. Quite");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.DisplayEndingMessage();
                breathingActivity.ShowSpinner(5);
                breathingActivity.ShowCountDown(5);
            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {

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

