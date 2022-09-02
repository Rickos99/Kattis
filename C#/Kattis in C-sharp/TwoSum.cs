using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/twosum
    internal class TwoSum
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var numbers = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(numbers[0]) + int.Parse(numbers[1]));
        }
    }
}
