using System;
using System.Threading;

namespace DotinProjects.GuessNumberGame.Utility
{
    /// <summary>
    /// Represents a utility class for displaying advertisements in a game.
    /// </summary>
    public class Advertise
    {
        private static bool adUsed = false;

        /// <summary>
        /// Shows an advertisement to the player, offering them a chance to regain lives.
        /// </summary>
        /// <param name="playerLife">The current number of lives the player has.</param>
        public static void showAd(ref int playerLife)
        {
            if (!adUsed && playerLife == 1)
            {
                int choice = 0;
                do
                {
                    if (!adUsed && playerLife == 1)
                    {
                        Console.Clear();

                        Console.WriteLine("You are down to your last life!");
                        Console.WriteLine("Want to see an Advertise to regain 2 lives back?");
                        Console.WriteLine("1. Yes");
                        Console.WriteLine("2. No");

                        Console.Write("Enter your choice (1-2): ");
                        if (int.TryParse(Console.ReadLine(), out choice))
                        {
                            switch (choice)
                            {
                                case 1:
                                    Console.Clear();

                                    Console.WriteLine("Please wait until the timer goes off...");
                                    Thread.Sleep(2000);

                                    CountDown.MakeCountdown(20);
                                    playerLife += 2;

                                    Console.WriteLine($"You've regained 2 lives. Current lives: {playerLife}");

                                    adUsed = true;

                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 2:
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }
                    }
                    else
                    {
                        break;
                    }

                } while (choice != 2);
            }
        }
    }
}
