using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/echoechoecho
    class EchoEchoEcho
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var word = Console.ReadLine();
            Console.Write($"{word} {word} {word}");
        }
    }
}
