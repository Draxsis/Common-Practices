using System;
using System.Threading;

namespace DotinProjects.GuessNumberGame.Utility
{
    /// <summary>
    /// Represents a utility class for displaying Hints in a game.
    /// </summary>
    public class Help
    {
        private static bool hintUsed = false;


        public static void showHint(int playerLife, int correctNumber)
        {
            if (!hintUsed && playerLife == 4 || playerLife == 5)
            {
                int choice = 0;
                do
                {
                    if (!hintUsed && playerLife == 4 || playerLife == 5)
                    {
                        Console.Clear();

                        Console.WriteLine("(it cost a life!) | Do you need help ? : ");
                        Console.WriteLine("1. Yes");
                        Console.WriteLine("2. No");

                        Console.Write("Enter your choice (1-2): ");
                        if (int.TryParse(Console.ReadLine(), out choice))
                        {
                            switch (choice)
                            {
                                case 1:

                                    var Hint = NumericToolbox.ShuffleNumber(correctNumber);

                                    Console.Clear();

                                    Console.WriteLine($"here is the number but shuffled ! {Hint}");
                                    Thread.Sleep(2000);

                                    playerLife --;
                                    hintUsed = true;

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
