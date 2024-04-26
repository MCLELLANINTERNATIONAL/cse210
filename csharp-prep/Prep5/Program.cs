using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program! ");
    }

    static string PromptUserName()
    {
        Console.Write("Pleae enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber} ");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favouriteNumber = PromptUserNumber();
        int squareNumber = SquareNumber(favouriteNumber);
        DisplayResult(name, squareNumber);
    }
}





