using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/nastyhacks
    internal class NastyHacks
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var cases = int.Parse(Console.ReadLine());
            for (; cases > 0; cases--)
            {
                var line = Console.ReadLine().Split(' ');
                var r = int.Parse(line[0]);
                var e = int.Parse(line[1]);
                var c = int.Parse(line[2]);
                var expectedRevenue = e - c - r;

                if (expectedRevenue < 0) Console.WriteLine("do not advertise");
                else if (expectedRevenue > 0) Console.WriteLine("advertise");
                else Console.WriteLine("does not matter");
            }
        }
    }
}
