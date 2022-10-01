using System;
using System.Collections.Generic;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/babelfish
    class Babelfish
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var dictionary = new Dictionary<string, string>();

            string entry;
            while ((entry = Console.ReadLine()) != string.Empty)
            {
                var inputSplit = entry.Split(new[] { ' ' }, 2);
                dictionary.Add(inputSplit[1], inputSplit[0]);
            }

            string word;
            while ((word = Console.ReadLine()) != null)
            {
                if (dictionary.TryGetValue(word, out string translation))
                    Console.WriteLine(translation);
                else
                    Console.WriteLine("eh");
            }
        }
    }
}
