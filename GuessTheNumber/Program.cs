using System;
/// <summary>
/// An Unimaginative Guess the number engine
/// Deliberatly dumb.
/// With some deliberate logic
/// </summary>
namespace GuessTheNumber
{
    class Program
    {
        /// <summary>
        /// Main is your programs entrypoint, for most purposes you should
        /// regard it as being the first piece of code in your program that will be executed.
        /// (this is almost 99% true, and is good enough for now.)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            Random nGenerator = new Random();
            //Some error trapping
            if (args.Length == 0)
            {
                Console.WriteLine("GuessTheNumber requires 2 parameters the first is the number of guesses, the second is the max number I pick from.");
                return;
            }

            int numberOfTries = int.Parse(args[0]);
            int ceiling = int.Parse(args[1]);

            //TODO: example text to show use of task list in VS
            int wins = 0;
            int losses = 0;
            for (int j = 0; j < 3; j++)
            {
                int myNumber = nGenerator.Next(ceiling);

                string playerGuess="";
                int playerGuessNum = 0;
                Console.WriteLine($"I am thinking of a whole number between 0 and {ceiling}");
                Console.WriteLine($"Can you try and guess it in less than {numberOfTries} tries ?");

            
                for (int i = 0; i < numberOfTries; i++)
                {
                    Console.WriteLine("You have " + (numberOfTries - i).ToString() + " tries left.");
                    Console.WriteLine("Take a guess ?");
                    playerGuess = Console.ReadLine();
                    playerGuessNum = int.Parse(playerGuess);
                    if (playerGuessNum > myNumber)
                    {
                        Console.WriteLine("Too High, Try again.");
                    }
                    else if (playerGuessNum < myNumber)
                    {
                        Console.WriteLine("Too Low, Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Well Done. You took {i + 1} attempts.");
                        wins++;
                        break;
                    }
                    if (playerGuessNum != myNumber && i == (numberOfTries - 1))
                    {
                        Console.WriteLine("Too bad you didn't guess it, I'm just too smart.");
                        losses++;
                    }
                }
                Console.WriteLine($"Wins: {wins} \nLosses: {losses}\n");
            }

        }
    }
}
