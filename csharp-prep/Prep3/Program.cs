using System;

class GuessMyNumberGame
{
    static void Main(string[] args)
    {
        //System generated random number
        //User input to guess the number 
        //System guides user by higher or lower output till number is correctly guessed
        //Calculates and outputs number of times you took to guess system generated number 
        //Loops for user to guess and play multiple times
        
        Random randomGenerator = new Random();
        bool playAgain = true;
        
        while (playAgain)
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = 0;
            int numberOfGuesses = 0;

            Console.WriteLine($"I have choosen a number between 1 and 100. Try to guess it! ");

            while (guess != magicNumber)
            {
                Console.WriteLine("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses++;
                
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it! ");
                    Console.WriteLine($"You took {numberOfGuesses} guesses. ");
                }
            }
                Console.WriteLine("Do you want to play again? Yes/ No");
                string response = Console.ReadLine().ToLower();
                if (response != "yes")
            {
                playAgain = false;
            }
        }
    }    
}
