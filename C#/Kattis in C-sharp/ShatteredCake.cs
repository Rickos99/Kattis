using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/shatteredcake
    internal class ShatteredCake
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var width = int.Parse(Console.ReadLine());
            var pieces = int.Parse(Console.ReadLine());
            var area = 0;
            for (int i = 0; i < pieces; i++)
            {
                var piece = Console.ReadLine().Split(' ');
                area += int.Parse(piece[0]) * int.Parse(piece[1]);
            }
            Console.WriteLine(area / width);
        }
    }
}
