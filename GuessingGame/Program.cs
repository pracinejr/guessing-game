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
            int secretNumber = rnd.Next(1, 101);

            while (Guesses.Count < 4 ) 
            {
            Console.WriteLine("Guess the secret number. ");
            Console.Write($"Remaining guesses: ({4 - (Guesses.Count)})");
            string answer = Console.ReadLine().ToLower();
            int userNumGuess = int.Parse(answer);
            // Console.WriteLine($"{secretNumber}");
            // Console.Write($"your guess was {userNumGuess}");
            if (secretNumber == userNumGuess) 
            {
                Console.WriteLine("You guessed correctly!");
                break;
            } else 
            {
                Guesses.Add(userNumGuess);
                Console.WriteLine("Wrong answer, sorry.");
            }
            }
        }
    }
}
