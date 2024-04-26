using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userName = -1;
        while (userName != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            int userNumber = int.Parse(userResponse);

            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            }
        
            else if (numbers.Count > 0)
            //1: Compute the sum total of the list 
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }

            Console.WriteLine($"The sum is {sum} ");

            //2.Compute the average number of the list
            float average = ((float)sum) / numbers.Count; 
            Console.WriteLine($"The average is: {average} ");

            //3. Comopute max number
            int max = numbers[0];
            foreach (int number in numbers)
            {
            if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The max is: {max}");
            }
            else
            {
                Console.WriteLine("No numbers were entered.");
            }
        }
    }
}