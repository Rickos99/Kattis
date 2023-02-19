using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/pyramids
    internal sealed class Pyramids
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var blocks = int.Parse(Console.ReadLine());
            var height = 0;
            while (blocks >= 0)
            {
                height++;
                var side = height * 2 - 1;
                blocks -= side * side;
            }
            Console.WriteLine(height - 1);
        }
    }
}
