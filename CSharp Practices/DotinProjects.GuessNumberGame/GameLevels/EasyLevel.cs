using DotinProjects.GuessNumberGame.Utility;
using System;
using System.Threading;

namespace DotinProjects.GuessNumberGame.GameLevels
{
    public class EasyLevel
    {
        public static void Start()
        {

            // intro for level
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            LoadingScreen.ShowLoadingScreen("Starting (Easy mode) and Generating number between (1 to 200)");

            // generate guess number 
            Random random = new Random();
            int correctNumber = random.Next(1, 201);

            // store player guess
            int playerGuess;

            // player lives
            int playerLife = 50;


            // Logic and player answer validation
            do
            {

                Console.WriteLine($"You have {playerLife} lives. Please enter your guess: ");


                if (int.TryParse(Console.ReadLine(), out playerGuess))
                {
                    // win statement
                    if (playerGuess == correctNumber)
                    {
                        Console.Clear();
                        Console.WriteLine($"Congratulations! You guessed the correct number. {correctNumber}");
                        Thread.Sleep(2000);

                        Console.WriteLine("Press Any key to continue.");
                        Console.ReadLine();

                        LoadingScreen.ShowLoadingScreen("Redirect to Main Menu");
                        StartingMenu.ShowStartingMenu();
                    }

                    // player guess is bigger than number statement
                    else if (playerGuess > correctNumber)
                    {
                        Console.WriteLine("the number is Smaller than your Guess !");
                        Thread.Sleep(800);
                        playerLife--;

                        if (playerLife == 0)
                        {

                            Console.Clear();

                            Console.WriteLine("Sorry, you've run out of lives. :( ");
                            Thread.Sleep(2000);

                            Console.Clear();

                            LoadingScreen.ShowLoadingScreen("Redirect to Main Menu");
                            StartingMenu.ShowStartingMenu();

                        }

                    }

                    // player guess is smaller than number statement
                    else if (playerGuess < correctNumber)
                    {
                        Console.WriteLine("the number is Bigger than your Guess !");
                        Thread.Sleep(800);
                        playerLife--;

                        if (playerLife == 0)
                        {

                            Console.Clear();

                            Console.WriteLine("Sorry, you've run out of lives. :( ");
                            Thread.Sleep(2000);

                            Console.Clear();

                            LoadingScreen.ShowLoadingScreen("Redirect to Main Menu");
                            StartingMenu.ShowStartingMenu();

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

            } while (playerGuess != correctNumber && playerLife > 0);
        }
    }
}
