using System;
using System.Threading;

namespace DotinProjects.GuessNumberGame.Utility
{
    /// <summary>
    /// Provides functionality to display a loading screen with animated dots.
    /// </summary>
    public class LoadingScreen
    {
        /// <summary>
        /// Displays a loading screen with animated dots and a specified loading message.
        /// </summary>
        /// <param name="loadMessage">The message to be displayed during the loading screen.</param>
        /// <remarks>
        /// This method clears the console, prints the loading message with animated dots,
        /// and introduces a delay to simulate a loading effect.
        /// </remarks>
        public static void ShowLoadingScreen(string loadMessage)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine($"{loadMessage} {new string('.', i + 1)}");
                Thread.Sleep(800);
                Console.Clear();
            }
        }
    }
}
