using System;

namespace Kattis_in_C_sharp
{
    internal sealed class OneDFroggerEasy
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var input = Console.ReadLine().Split(' ');
            var n = int.Parse(input[0]);
            var s = int.Parse(input[1]);
            var m = int.Parse(input[2]);
            var board = ParseBoard(Console.ReadLine());

            var fate = GetFroggerFate(n, s, m, board);

            Console.WriteLine(fate.fate);
            Console.WriteLine(fate.move);
        }

        private static int[] ParseBoard(string str)
        {
            var strComponents = str.Split(' ');
            var board = new int[strComponents.Length];
            for (int i = 0; i < strComponents.Length; i++)
            {
                board[i] = int.Parse(strComponents[i]);
            }
            return board;
        }

        private static (string fate, int move) GetFroggerFate(int n, int s, int m, int[] board)
        {
            s--; // Make zero-indexed

            var boardVisits = new int[board.Length];
            var moves = 0;

            boardVisits[s] = 1;
            while (true)
            {
                if (board[s] == m) return ("magic", moves);
                if (boardVisits[s] >= 2) return ("cycle", moves);

                s += board[s];
                moves++;

                if (s >= board.Length) return ("right", moves);
                if (s < 0) return ("left", moves);
                boardVisits[s]++;
            }
        }
    }
}
