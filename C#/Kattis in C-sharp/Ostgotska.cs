using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/ostgotska
    internal class Ostgotska
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var sentence = Console.ReadLine().Split(' ');
            var wordLimit = sentence.Length * 0.4;

            var wordThatContainsAe = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (WordContainsAE(sentence[i])) wordThatContainsAe++;
                if (wordThatContainsAe >= wordLimit)
                {
                    Console.WriteLine("dae ae ju traeligt va");
                    return;
                }
            }
            Console.WriteLine("haer talar vi rikssvenska");
        }

        static bool WordContainsAE(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == 'a' && word[i+1] == 'e') return true;
            }
            return false;
        }
    }
}
