using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/triarea
    internal class TriArea
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var numbers = Console.ReadLine().Split(' ');
            var area = (int.Parse(numbers[0]) * int.Parse(numbers[1])) / 2f;
            Console.WriteLine(area);
        }
    }
}
