using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/kemija08
    static class Kemija08
    {
        //public static void Main() => Solution();

        static void Solution()
        {

           string input = Console.ReadLine();
           Tuple<string, string>[] replacements = new Tuple<string, string>[] {
               new Tuple<string, string>("apa", "a"),
               new Tuple<string, string>("epe", "e"),
               new Tuple<string, string>("ipi", "i"),
               new Tuple<string, string>("opo", "o"),
               new Tuple<string, string>("upu", "u"),
           };

           foreach (var replacement in replacements)
           {
               input = input.Replace(replacement.Item1, replacement.Item2);
           }

           Console.WriteLine(input);
        }
    }
}
