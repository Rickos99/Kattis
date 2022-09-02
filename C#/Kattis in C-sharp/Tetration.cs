using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/tetration
    internal class Tetration
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var n = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(n, 1 / n));
        }
    }
}
