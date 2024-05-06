using System;
using System.Collections.Generic;
using System.IO;

//Added Creativity : Daily Scripture Class

class Program
{
    static void Main(string[] args)
    
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        string choice;
        do
        {
            Console.WriteLine("Please select one of the following Choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    journal.WriteEntry();
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("What is the file name you want to Load to ?");
                    string loadName = Console.ReadLine();
                    journal.LoadFromFile(loadName);
                    Console.WriteLine("Congragulations, your entry has been loaded!");

                    break;
                case "4":
                    Console.WriteLine("What is the file name you want to save to?");
                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    Console.WriteLine("Congragulations, your entry has been saved!");
                    break;
                case "5":
                    Console.WriteLine("Exiting the Journal Program!");
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again.");
                    break;
            }
            Console.WriteLine();
        } while (choice != "5");
    }
}   
    