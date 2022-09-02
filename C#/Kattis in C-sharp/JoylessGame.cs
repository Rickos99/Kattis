using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/joylessgame
    internal class JoylessGame
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                Console.WriteLine(GetWinner(Console.ReadLine()));
            }
        }

        static string GetWinner(string str)
        {
            if (str[0] == str[str.Length - 1])
            {
                return str.Length % 2 == 1 ? "Bash" : "Chikapu";
            }
            else
            {
                return str.Length % 2 == 0 ? "Bash" : "Chikapu";
            }
        }
    }
}
