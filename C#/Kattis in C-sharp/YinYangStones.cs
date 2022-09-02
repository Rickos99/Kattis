using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/yinyangstones
    class YinYangStones
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var sequence = Console.ReadLine();
            int black = 0;
            int white = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == 'B') black++;
                else white++;
            }
            Console.Write(black == white ? 1 : 0);
        }
    }
}
