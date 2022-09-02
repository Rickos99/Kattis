using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/alphabet
    class Alphabet
    {
        //public static void Main() => Solution();

        public static void Solution()
        {
           string input = Console.ReadLine();
           string alphabet = "abcdefghijklmnopqrstuvwxyz";
           Console.WriteLine(alphabet.Length - LongestCommonSubsequence(input, alphabet));
        }

        public static int LongestCommonSubsequence(string pat, string alphabet)
        {
            int m = pat.Length;
            int n = alphabet.Length;

            int[,] lcs = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        lcs[i, j] = 0;
                    }
                    else if (pat[i - 1] == alphabet[j - 1])
                    {
                        lcs[i, j] = 1 + lcs[i - 1, j - 1];
                    }
                    else
                    {
                        lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);
                    }
                }
            }
            return lcs[m, n];
        }
    }
}
