using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/twostones
    internal class TwoStones
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var stones = Console.ReadLine();
            if(stones[stones.Length - 1] % 2 == 0) Console.WriteLine("Bob");
            else Console.WriteLine("Alice");
        }
    }
}
