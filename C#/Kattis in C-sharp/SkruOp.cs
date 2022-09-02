using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/skruop
    internal class SkruOp
    {
        public const int LOWER_LIMIT = 0;
        public const int UPPER_LIMIT = 10;

        //public static void Main() => Solution();

        static void Solution()
        {
            var cases = int.Parse(Console.ReadLine());
            var volume = 7;
            for (; cases > 0; cases--)
            {
                var action = Console.ReadLine();
                if (action.Length == 8)
                {
                    if (volume + 1 <= UPPER_LIMIT)
                    {
                        volume += 1;
                    }
                }
                else if (volume - 1 >= LOWER_LIMIT)
                {
                    volume -= 1;
                }
            }

            Console.WriteLine(volume);
        }
    }
}
