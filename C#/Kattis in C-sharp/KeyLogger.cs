using System;
using System.Collections.Generic;
using System.Text;

namespace Kattis_in_C_sharp.making
{
    // https://open.kattis.com/problems/keylogger
    class KeyLogger
    {
        private static readonly Dictionary<string, (string key, bool isSpecialKey)> soundTable =
            new Dictionary<string, (string key, bool isSpecialKey)>
        {
            {"clank", ("a", false) },
            {"bong", ("b", false) },
            {"click", ("c", false) },
            {"tap", ("d", false) },
            {"poing", ("e", false) },
            {"clonk", ("f", false) },
            {"clack", ("g", false) },
            {"ping", ("h", false) },
            {"tip", ("i", false) },
            {"cloing", ("j", false) },
            {"tic", ("k", false) },
            {"cling", ("l", false) },
            {"bing", ("m", false) },
            {"pong", ("n", false) },
            {"clang", ("o", false) },
            {"pang", ("p", false) },
            {"clong", ("q", false) },
            {"tac", ("r", false) },
            {"boing", ("s", false) },
            {"boink", ("t", false) },
            {"cloink", ("u", false) },
            {"rattle", ("v", false) },
            {"clock", ("w", false) },
            {"toc", ("x", false) },
            {"clink", ("y", false) },
            {"tuc", ("z", false) },

            {"whack", ("SPACEBAR", true) },
            {"bump", ("CAPSLOCK", true) },
            {"pop", ("DELETE", true) },
            {"dink", ("SHIFT-DOWN", true) },
            {"thumb", ("SHIFT-UP", true) },
        };

        //public static void Main() => Solution();

        static void Solution()
        {
            var cases = int.Parse(Console.ReadLine());
            var makeUppercase = false;
            var sb = new StringBuilder(cases);
            for (int i = 0; i < cases; i++)
            {
                var sound = Console.ReadLine();
                var entry = soundTable[sound];
                if (!entry.isSpecialKey)
                {
                    sb.Append(makeUppercase ? entry.key.ToUpper() : entry.key);
                }
                else
                {
                    switch (entry.key)
                    {
                        case "SPACEBAR":
                            sb.Append(" ");
                            break;
                        case "CAPSLOCK":
                            makeUppercase = !makeUppercase;
                            break;
                        case "DELETE":
                            if (sb.Length != 0)
                                sb.Remove(sb.Length - 1, 1);
                            break;
                        case "SHIFT-DOWN":
                            makeUppercase = !makeUppercase;
                            break;
                        case "SHIFT-UP":
                            makeUppercase = !makeUppercase;
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
