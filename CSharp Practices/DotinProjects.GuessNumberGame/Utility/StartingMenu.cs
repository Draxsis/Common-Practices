using System;

namespace DotinProjects.GuessNumberGame.Utility
{
    /// <summary>
    /// Provides functionality to display the starting menu for the Guess Number Game.
    /// </summary>
    public class StartingMenu
    {
        /// <summary>
        /// Displays the starting menu for the Guess Number Game, allowing the player to play the game or exit.
        /// </summary>
        /// <remarks>
        /// This method presents the player with options to either start the game or exit the application.
        /// It handles user input, calling the appropriate methods based on the selected choice.
        /// </remarks>
        public static void ShowStartingMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            int choice;
            do
            {
                Console.Clear();

                Console.WriteLine("Guess Number Game Menu:");
                Console.WriteLine("1. Play Game");
                Console.WriteLine("2. Exit");

                Console.Write("Enter your choice (1-2): ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Game.PlayGame();
                            break;

                        case 2:
                            Console.WriteLine("Goodbye!");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select Play Game or Exit.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

            } while (choice != 2);

            Console.Clear();
        }
    }
}
