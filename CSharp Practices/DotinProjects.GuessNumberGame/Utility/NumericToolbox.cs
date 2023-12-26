using System;

namespace DotinProjects.GuessNumberGame.Utility
{
    public class NumericToolbox
    {
        public static int ShuffleNumber(int number)
        {
            // Convert the number to an array of digits
            char[] digits = number.ToString().ToCharArray();

            // Shuffle the array
            Random random = new Random();
            int n = digits.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                var value = digits[k];
                digits[k] = digits[n];
                digits[n] = value;
            }

            // Convert the shuffled array back to an integer
            int shuffledNumber = int.Parse(new string(digits));

            return shuffledNumber;
        }
    }

}
