using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/oddities
    internal class Oddities
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var cases = int.Parse(Console.ReadLine());

            for (; cases > 0; cases--)
            {
                var x = Console.ReadLine();
                if (x[x.Length - 1] % 2 == 0) Console.WriteLine($"{x} is even");
                else Console.WriteLine($"{x} is odd");
            }
        }
    }
}
