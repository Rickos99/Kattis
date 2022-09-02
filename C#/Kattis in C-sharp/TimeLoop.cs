using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/timeloop
    internal class TimeLoop
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} Abracadabra");
            }
        }
    }
}
