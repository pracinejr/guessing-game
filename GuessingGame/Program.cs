using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Guesses = new List<int>();
            Random rnd = new Random();

            Console.WriteLine(@"Difficulty options: 
            ~Easy = (8 chances to guess) 
            ~Medium = (6 chances to guess) 
            ~Hard = (4 chances to guess)
            ~Cheater = (Unlimited Chances to guess)");
            Console.Write("Enter your difficulty choice: ");
            string difficultyLevel = Console.ReadLine().ToLower();
            int guessLimit;


            if (difficultyLevel == "easy")
            {
                guessLimit = 7;
            }
            else if (difficultyLevel == "medium")
            {
                guessLimit = 5;
            }
            else if (difficultyLevel == "hard")
            {
                guessLimit = 3;
            }
            else 
            {
                guessLimit = int.MaxValue;
            }


            
            // Console.Write($"Remaining guesses: ({4 - (Guesses.Count)})");
            // Console.Write($"your guess was {userNumGuess}");

            Console.WriteLine("Guess the secret number. ");
            // string answer = Console.ReadLine().ToLower();
            int userNumGuess = 0; //= int.Parse(Console.ReadLine());
            int secretNumber = rnd.Next(1, 101);
            int guessCount = 0;
            bool outOfGuesses = false;
            Console.WriteLine($"{secretNumber}");


            while (userNumGuess != secretNumber && !outOfGuesses)
                {
                    if (guessCount <= guessLimit)
                    {
                        if (secretNumber < userNumGuess) 
                        {
                        int guessesLeft = guessLimit - guessCount;
                        userNumGuess = int.Parse(Console.ReadLine());
                        guessCount++;
                            Console.WriteLine($"Your answer is too high and is incorrect, sorry. You have {guessesLeft} guesses left. Enter your next guess: ");
                        }
                        else
                        {
                        int guessesLeft = guessLimit - guessCount;
                        userNumGuess = int.Parse(Console.ReadLine());
                        guessCount++;
                            Console.WriteLine($"Your answer is too low and is incorrect, sorry. You have {guessesLeft} guesses left. Enter your next guess: ");
                        }
                    }
                    else 
                    {
                        outOfGuesses = true;
                    }    
                }
                if (outOfGuesses) 
                {
                    Console.WriteLine("Your answer is incorrect and you're out of guess.");
                }
                else
                {
                    Console.WriteLine("You were right!");
                }
        }
            
    };
};

