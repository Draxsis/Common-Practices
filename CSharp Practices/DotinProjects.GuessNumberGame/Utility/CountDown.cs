using System;
using System.Threading;

namespace DotinProjects.GuessNumberGame.Utility
{
    /// <summary>
    /// Provides functionality for a countdown timer.
    /// </summary>
    public class CountDown
    {
        /// <summary>
        /// Initiates a countdown timer for the specified number of seconds.
        /// </summary>
        /// <param name="seconds">The duration of the countdown in seconds.</param>
        /// <remarks>
        /// This method displays a countdown timer in the console, updating every second.
        /// </remarks>
        public static void MakeCountdown(int seconds)
        {
            Console.WriteLine($"Countdown started for {seconds} seconds...");

            for (int i = seconds; i > 0; i--)
            {

                Console.WriteLine("  ____  _              _____       _     _             ");
                Console.WriteLine(" |  _ \\| |_   _  ___  |  ___|_   _| |__ (_)_ __   __ _ ");
                Console.WriteLine(" | | | | | | | |/ _ \\ | |_  | | | | '_ \\| | '_ \\ / _` |");
                Console.WriteLine(" | |_| | | |_| |  __/ |  _| | |_| | | | | | | | | (_| |");
                Console.WriteLine(" |____/|_|\\__,_|\\___| |_|    \\__, |_| |_|_| |_|\\__, |");
                Console.WriteLine("                            |___/                 |___/ ");
                Console.WriteLine($"Time remaining: {i} seconds");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
