using System;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/spellingbee
    class SpellingBee
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var puzzle = Console.ReadLine();
            var cases = int.Parse(Console.ReadLine());
            for (; cases > 0; cases--)
            {
                var word = Console.ReadLine();
                if (IsValidWord(word, puzzle))
                    Console.WriteLine(word);
            }
        }

        private static bool IsValidWord(string word, string puzzle)
        {
            if (word.Length < 4) return false;
            if (word.IndexOf(puzzle[0]) == -1) return false;

            for (int i = 0; i < word.Length; i++)
            {
                if (puzzle.Contains(word[i]) == false) return false;
            }
            return true;
        }
    }
}
