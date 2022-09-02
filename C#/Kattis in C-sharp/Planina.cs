using System;

namespace Kattis_in_C_sharp
{
    internal class Planina
    {
        // https://open.kattis.com/problems/planina
        //public static void Main() => Solution();

        static void Solution()
        {
            var iteration = int.Parse(Console.ReadLine());
            var points = Math.Pow(2d, iteration) + 1;
            Console.WriteLine(points * points);
        }
    }
}
