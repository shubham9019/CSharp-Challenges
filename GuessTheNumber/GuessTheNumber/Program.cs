using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            
            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            bool flag = true;
            int guessNum = 0;
            int guessCount = 0;
            do
            {
                Console.WriteLine("What's your guess?");
                string theGuess = Console.ReadLine();
                bool result = Int32.TryParse(theGuess, out guessNum);

                if (!result)
                {
                    Console.WriteLine("Enter a number.");
                }
                else
                {
                    if (guessNum == -1)
                    {
                        Console.WriteLine($"Oh well. I was thinking of {theNumber}");
                        flag = false;
                    }
                    else
                    {
                        guessCount++;

                        if (guessNum == theNumber)
                        {
                            Console.WriteLine($"You got it in {guessCount} guesses!");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Nope, {0} than that.", guessNum < theNumber ? "higher" : "lower");
                        }
                    }
                }
            } while (flag);
            Console.ReadLine();
        }
    }
}
