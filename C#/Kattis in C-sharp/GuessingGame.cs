using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/guessinggame
    class GuessingGame
    {
        //public static void Main() => Solution();

        static void Solution()
        {
           var game = new GuessingGame();
           string gameResult;
           while ((gameResult = game.StartRound()) != string.Empty)
           {
               Console.WriteLine(gameResult);
           }
        }

        public string StartRound()
        {
            string input;
            int lowerBound = 0, upperBound = 11, lastGuess = 0;
            while ((input = Console.ReadLine()) != string.Empty)
            {
                if (IsInputGuess(input, out int guess))
                {
                    if (guess == 0) break;
                    lastGuess = guess;
                    continue;
                }

                switch (input)
                {
                    case "too high":
                        if (upperBound > lastGuess)
                        {
                            upperBound = lastGuess;
                        }
                        continue;
                    case "too low":
                        if (lowerBound < lastGuess)
                        {
                            lowerBound = lastGuess;
                        }
                        continue;
                    default:
                        break;
                }

                var stanIsHonest = StanIsHonest(lowerBound, upperBound, lastGuess);

                return stanIsHonest ? "Stan may be honest" : "Stan is dishonest";
            }
            return string.Empty;
        }

        private bool StanIsHonest(int lowerBound, int upperBound, int guess)
        {
            bool invalidBoundries = upperBound - lowerBound <= 1;
            bool rightGuessInRange = guess < upperBound && guess > lowerBound;

            return !invalidBoundries && rightGuessInRange;
        }

        private bool IsInputGuess(string str, out int guess)
        {
            return int.TryParse(str, out guess);
        }
    }
}
