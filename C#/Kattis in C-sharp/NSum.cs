using System;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/nsum
    internal class NSum
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            _ = Console.ReadLine();
            Console.WriteLine(Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .Sum());

        }
    }
}
