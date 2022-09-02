using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/oddecho
    internal class OddEcho
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                string word = Console.ReadLine();
                if (i % 2 == 0) Console.WriteLine(word);
            }
        }
    }
}
