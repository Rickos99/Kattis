using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/whichisgreater
    class WhichIsGreater
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var numbers = Console.ReadLine().Split(' ');

            if (int.Parse(numbers[0]) <= int.Parse(numbers[1])) Console.WriteLine(0);
            else Console.WriteLine(1);
        }
    }
}
