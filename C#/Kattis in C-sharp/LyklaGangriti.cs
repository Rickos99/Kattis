using System;
using System.Collections.Generic;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/lyklagangriti
    internal class LyklaGangriti
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var input = Console.ReadLine();
            var password = new List<char>(input.Length);
            int cursor = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var symbol = input[i];

                switch (symbol)
                {
                    case 'L':
                        cursor--;
                        break;

                    case 'R':
                        cursor++;
                        break;

                    case 'B':
                        cursor--;
                        password.RemoveAt(cursor);
                        break;

                    default:
                        password.Insert(cursor, symbol);
                        cursor++;
                        break;
                }
            }
            Console.WriteLine(string.Join("", password));
        }
    }
}
