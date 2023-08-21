using System;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome display title
            Console.WriteLine("=====================");
            Console.WriteLine("Number guessing game!");
            Console.WriteLine("=====================");

            // Game restart logic
            bool restartGame = true;
            String userRestartInput;
            while (restartGame) 
            {
                bool guessIsRight = false;
                bool checkRestartInput = true;

                int highNumber = 100;
                int lowNumber = 1;
                int randomNumber = 50;

                int userGuess = 0;
                int guesses = 0;

                Random random = new Random();
                randomNumber = random.Next(lowNumber, highNumber + 1);

                Console.WriteLine($"I have picked a number between {lowNumber} and {highNumber}!");
                while (!guessIsRight) { 
                    Console.Write("Please insert the number you think I have chosen:");
                    try
                    {
                        userGuess = Int32.Parse(Console.ReadLine());
                        guesses++;

                        if (userGuess < lowNumber || userGuess > highNumber) 
                        {
                            Console.WriteLine($"You must insert a whole number (integer) between {lowNumber} and {highNumber}!");
                            continue;
                        }
                    } catch (FormatException e) {
                        Console.WriteLine("You must insert a valid, whole, number (integer)!");
                        continue;
                    }

                    if ( userGuess == randomNumber) 
                    {
                        guessIsRight = true;
                        Console.WriteLine($"You have won! It took you: {guesses} guesses!");
                    }
                    else if ( userGuess < randomNumber) 
                    {
                        Console.WriteLine("The number you have chosen is to low!");
                        continue;
                    }
                    else if (userGuess > randomNumber)
                    {
                        Console.WriteLine("The number you have chosen is to high!");
                        continue;
                    }
                }

                while (checkRestartInput)
                {
                    Console.Write("Thank you for playing the number guessing game! Do you want to play again? (Y/n)");
                    userRestartInput = Console.ReadLine();
                    if (userRestartInput != null)
                    {
                        if (userRestartInput.ToUpper() == "Y")
                        {
                            restartGame = true;
                            checkRestartInput = false;
                        }
                        else if (userRestartInput.ToUpper() == "N")
                        {
                            restartGame = false;
                            checkRestartInput = false;
                        }
                        else
                        {
                            Console.WriteLine("Please insert y or n!");
                            checkRestartInput = true;
                        }
                    }
                    else
                    {
                        restartGame = true;
                        checkRestartInput = false;
                    }
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}