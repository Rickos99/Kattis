using System;
using System.Collections.Generic;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/stringmatching
    // NOTES:
    // Consider chapter 32 in "introduction to algorithms"
    public class StringMatching
    {
        //public static void Main() => Solution();

        public static void Solution()
        {
            string pattern;
            while ((pattern = Console.ReadLine()) != null)
            {
                var text = Console.ReadLine();
                var occurences = KMPSearch(pattern, text);
                Console.WriteLine(string.Join(" ", occurences));
            }
        }

        static List<int> KMPSearch(string pattern, string text)
        {
            int M = pattern.Length;
            int N = text.Length;

            var occurences = new List<int>();

            int[] lps = new int[M];
            int j = 0;

            ComputeLPSArray(pattern, M, lps);

            int i = 0;
            while (i < N)
            {
                if (pattern[j] == text[i])
                {
                    j++;
                    i++;
                }
                if (j == M)
                {
                    occurences.Add(i - j);
                    j = lps[j - 1];
                }

                else if (i < N && pattern[j] != text[i])
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }

            return occurences;
        }

        static void ComputeLPSArray(string pattern, int M, int[] lps)
        {
            int len = 0;
            int i = 1;
            lps[0] = 0;

            while (i < M)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }
    }
}
