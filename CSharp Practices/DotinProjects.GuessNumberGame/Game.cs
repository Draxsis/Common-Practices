using DotinProjects.GuessNumberGame.GameLevels;
using DotinProjects.GuessNumberGame.Utility;
using System;

namespace DotinProjects.GuessNumberGame
{
    /// <summary>
    /// Represents the game class responsible for managing the flow of the guessing game.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Starts the guessing game, gets the player name and allowing the player to choose a difficulty level.
        /// </summary>
        public static void PlayGame()
        {
            Console.Clear();

            // Prompt the player to enter their name.
            Console.WriteLine("Please enter your name: ");
            var playerName = Console.ReadLine();

            // Loop for selecting the game level.
            int choice;
            do
            {
                Console.Clear();
                LoadingScreen.ShowLoadingScreen("Loading Game");
                Console.Clear();

                Console.WriteLine($"Select your level, {playerName}:");
                Console.WriteLine("1. Easy");
                Console.WriteLine("2. Normal");
                Console.WriteLine("3. Hard");

                Console.Write("Enter your choice (1-3): ");

                // Validate and process the player's choice.
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            EasyLevel.Start();
                            break;

                        case 2:
                            NormalLevel.Start();
                            break;

                        case 3:
                            HardLevel.Start();
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid difficulty level (1-3).");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (choice != 3);
        }
    }
}
