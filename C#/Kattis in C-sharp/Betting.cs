using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/betting
    internal class Betting
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var percentageOptionOne = int.Parse(Console.ReadLine())/100f;
            var percentageOptionTwo = 1 - percentageOptionOne;

            var ratioOptionOne = 1 + percentageOptionTwo / percentageOptionOne;
            var ratioOptionTwo = 1 + percentageOptionOne / percentageOptionTwo;

            Console.WriteLine(ratioOptionOne);
            Console.WriteLine(ratioOptionTwo);
        }
    }
}
