using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number");
            string answer = Console.ReadLine().ToLower();
            int userNumGuess = int.Parse(answer);
            Console.Write($"your guess was {userNumGuess}");
        }
    }
}
