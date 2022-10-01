using System;
using System.Collections.Generic;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/thegrandadventure
    class TheGrandAdventure
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var adventures = int.Parse(Console.ReadLine());
            for (; adventures > 0; adventures--)
            {
                var path = Console.ReadLine();
                Console.WriteLine(SuccessfulAdventure(path) ? "YES" : "NO");
            }
        }

        static bool SuccessfulAdventure(string path)
        {
            var backpack = new Stack<char>();
            for (int i = 0; i < path.Length; i++)
            {
                switch (path[i])
                {
                    case '$':
                        backpack.Push('$');
                        break;
                    case '|':
                        backpack.Push('|');
                        break;
                    case '*':
                        backpack.Push('*');
                        break;
                    case 't':
                        if (!TryToGiveItem(backpack, '|'))
                            return false;
                        break;
                    case 'j':
                        if (!TryToGiveItem(backpack, '*'))
                            return false;
                        break;
                    case 'b':
                        if (!TryToGiveItem(backpack, '$'))
                            return false;
                        break;

                    default: break;
                }
            }
            return backpack.Count == 0;
        }

        private static bool TryToGiveItem(Stack<char> backpack, char item)
        {
            if (backpack.Count != 0 && backpack.Peek() == item)
            {
                backpack.Pop();
                return true;
            }
            else return false;
        }
    }
}
