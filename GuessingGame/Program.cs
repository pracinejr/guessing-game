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
            int secretNumber = 42;

            Console.WriteLine("Guess the secret number");
            string answer = Console.ReadLine().ToLower();
            int userNumGuess = int.Parse(answer);
            // Console.Write($"your guess was {userNumGuess}");
            if (userNumGuess == secretNumber) 
            {
                Console.WriteLine("You guessed correctly!");
            } else 
            {
                Console.WriteLine("Wrong answer, sorry.");
            }
        }
    }
}
