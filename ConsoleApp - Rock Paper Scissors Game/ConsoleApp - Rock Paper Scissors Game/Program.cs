using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================");
            Console.WriteLine("Rock Paper Scissors");
            Console.WriteLine("===================");

            bool playAgain = true;
            while (playAgain) 
            {
                bool checkUserPlayAgainInput = true;
                bool gameEnded = false;
                String userRestartInput;
                while ( !gameEnded )
                {
                    String computerSelected;
                    String userSelected;

                    Random rand = new Random();
                    int selectorValue = rand.Next(1, 4);
                    switch (selectorValue)
                    {
                        case 0:
                            computerSelected = "rock";
                            break;
                        case 1:
                            computerSelected = "paper";
                            break;
                        case 2:
                            computerSelected = "scissors";
                            break;
                        default:
                            computerSelected = "rock";
                            break;
                    }

                    Console.Write("What do you want to choose? rock, paper or scissors?");
                    userSelected = Console.ReadLine();

                    if (userSelected != null)
                    {
                        switch (userSelected.ToLower())
                        {
                            case "rock":
                                if (computerSelected == "rock")
                                {
                                    Console.WriteLine("Draw, try again!");
                                    gameEnded = false;
                                    continue;
                                }
                                else if (computerSelected == "paper")
                                {
                                    Console.WriteLine("You lost!");
                                    gameEnded = true;
                                    continue;
                                }
                                else if (computerSelected == "scissors")
                                {
                                    Console.WriteLine("You win!");
                                    gameEnded = true;
                                    continue;
                                }
                                continue;
                            case "paper":
                                if (computerSelected == "rock")
                                {
                                    Console.WriteLine("You win!");
                                    gameEnded = true;
                                    continue;
                                }
                                else if (computerSelected == "paper")
                                {
                                    Console.WriteLine("Draw, try again!");
                                    gameEnded = false;
                                    continue;
                                }
                                else if (computerSelected == "scissors")
                                {
                                    Console.WriteLine("You lost!");
                                    gameEnded = true;
                                    continue;
                                }
                                continue;
                            case "scissors":
                                if (computerSelected == "rock")
                                {
                                    Console.WriteLine("You lost!");
                                    gameEnded = true;
                                    continue;
                                }
                                else if (computerSelected == "paper")
                                {
                                    Console.WriteLine("You win!");
                                    gameEnded = true;
                                    continue;
                                }
                                else if (computerSelected == "scissors")
                                {
                                    Console.WriteLine("Draw, try again!");
                                    gameEnded = false;
                                    continue;
                                }
                                continue;
                            default:
                                Console.WriteLine("You must choose either rock, paper or scissors");
                                continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You must choose either rock, paper or scissors");
                        continue;
                    }
                }

                while (checkUserPlayAgainInput)
                {
                    Console.Write("Thank you for playing the rock, paper, scissors game! Do you want to play again? (Y/n)");
                    userRestartInput = Console.ReadLine();
                    if (userRestartInput != null)
                    {
                        if (userRestartInput.ToUpper() == "Y")
                        {
                            playAgain = true;
                            checkUserPlayAgainInput = false;
                        }
                        else if (userRestartInput.ToUpper() == "N")
                        {
                            playAgain = false;
                            checkUserPlayAgainInput = false;
                        }
                        else
                        {
                            Console.WriteLine("Please insert y or n!");
                            checkUserPlayAgainInput = true;
                        }
                    }
                    else
                    {
                        playAgain = true;
                        checkUserPlayAgainInput = false;
                    }
                }
            }
            Console.WriteLine("Thank you for playing!");
        }
    }
}