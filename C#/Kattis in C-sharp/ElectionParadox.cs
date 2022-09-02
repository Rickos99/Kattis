using System;

namespace Kattis_in_C_sharp
{
    internal class ElectionParadox
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            _ = Console.ReadLine();

            var cases = Console.ReadLine().Split();
            var regions = new int[cases.Length];
            for (int i = 0; i < cases.Length; i++)
            {
                regions[i] = int.Parse(cases[i]);
            }
            Array.Sort(regions);

            var votes = 0;
            int j = 0;
            for (; j < regions.Length / 2 + 1; j++)
            {
                votes += regions[j] / 2;
            }
            for (; j < regions.Length; j++)
            {
                votes += regions[j];
            }
            Console.WriteLine(votes);
        }
    }
}
