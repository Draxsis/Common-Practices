using System;
using DotinProjects.GuessNumberGame.Utility;


namespace DotinProjects.GuessNumberGame
{
    class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            // show LoadingScreen in console
            LoadingScreen.ShowLoadingScreen("Welcome to Guess Number Game !");

            // show Starting Menu 
            StartingMenu.ShowStartingMenu();

        }
    }
}
