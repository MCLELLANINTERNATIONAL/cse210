using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? "); // PUT "Enter the grade"
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        
        string grade = "";

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >=80 && percent < 90)
        {
           grade = "B"; 
        }
        else if (percent >=70 && percent < 80)
        {
           grade = "C";
        }
        else if (percent >=60 && percent < 70)
        {
           grade = "D"; 
        }
        else
        {
           grade = "F";
        }

            Console.WriteLine($"Your grade is: {grade}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }     
    }
}