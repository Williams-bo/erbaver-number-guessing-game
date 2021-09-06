using System;
using System.Collections.Generic;


namespace numberguessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Easy. numbers: 1-10

            List<int> numbers = new List<int> ();
            int input = 0;
            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine("Game rule: Guess the secret number between 1 to 10 to win. You have six trials. Goodluck!");
                Console.Write("Guess a number(Easy):");
                input = int.Parse(Console.ReadLine());
                // numbers.Add (input);

            if (input == 2) 
            {
                Console.WriteLine("correct guess mate!");
                break;
            }
            // else if (numbers[5] != 2)
            // {
            //     Console.Write("better luck next time mate");
            // }
            } 

            // Intermediate. numbers: 1-20
            int guess = 0;
            for (int i = 0; i < 4; i++) 
            {
                Console.WriteLine("Game rule: Guess the secret number between 1 to 20 to win. You have four trials. Goodluck!");
                Console.Write("Guess a number(Intermediate):");
                guess = int.Parse(Console.ReadLine());

            if (guess == 11) 
            {
                Console.WriteLine("correct guess mate!");
                break;
            }
            } 


             // Hard. numbers: 1-50
            int answer = 0;
            for (int i = 0; i < 4; i++) 
            {
                Console.WriteLine("Game rule: Guess the secret number between 1 to 50 to win. You have three trials. Goodluck!");
                Console.Write("Guess a number(Intermediate):");
                answer = int.Parse(Console.ReadLine());

            if (answer == 49) 
            {
                Console.WriteLine("correct guess mate!");
                break;
            }
            } 

        }
    }
}
