using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Guessing Game");
            StartGame();
        }

        static void StartGame()
        {
            string startMessage = "I am thinking of a number between 0 and 99";
            int mysteryNumber = new Random().Next(0, 100);
            int guessesRemaining = 10;
            int guessesMade = 0;
            bool gameWon = false;

            Console.WriteLine(startMessage);

            while (guessesRemaining > 0)
            {
                Console.WriteLine("Enter your guess:");
                int currentGuess = Convert.ToInt32(Console.ReadLine());
                guessesRemaining--;
                guessesMade++;

                if (currentGuess > mysteryNumber)
                {
                    Console.WriteLine("That's too high. Guess: " + guessesMade + ", Remaining: " + guessesRemaining);
                }
                else if (currentGuess < mysteryNumber)
                {
                    Console.WriteLine("That's too low. Guess: " + guessesMade + ", Remaining: " + guessesRemaining);
                }
                else
                {
                    Console.WriteLine("You got it!");
                    gameWon = true;
                    break;
                }
            }

            if (gameWon)
            {
                Console.WriteLine("Yes, it's " + mysteryNumber + "! It only took you " + guessesMade + " guesses.");
            }
            else
            {
                Console.WriteLine("No more guesses left! The number was: " + mysteryNumber + ".");
            }
        }
    }
}