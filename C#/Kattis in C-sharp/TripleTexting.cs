using System;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/tripletexting
    class TripleTexting
    {
        //public static void Main() => Solution();

        static void Solution()
        {
           string words = Console.ReadLine();
           char[] wordsArr = words.ToArray();
           int wordLen = wordsArr.Length / 3;

           for (int i = 0; i < wordLen; i++)
           {
               int a = wordsArr[i];
               int b = wordsArr[i + wordLen];
               int c = wordsArr[i + 2 * wordLen];
               int rem = (a + b + c) % 3;
               if (rem != 0)
               {
                   if (a - b == 0)
                   {
                       // a or b is correct, c is wrong
                       Console.WriteLine(words.Substring(0, wordLen));
                   }
                   else
                   {
                       // c is correct, a or b is wrong
                       Console.WriteLine(words.Substring(2 * wordLen, wordLen));
                   }
                   return;
               }
           }

           // All words are correct
           Console.WriteLine(words.Substring(0, wordLen));
        }
    }
}
