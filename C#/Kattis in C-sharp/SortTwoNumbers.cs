using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/sorttwonumbers
    internal class SortTwoNumbers
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var numbers = Console.ReadLine().Split(' ');
            if (int.Parse(numbers[0]) < int.Parse(numbers[1])) Console.WriteLine($"{numbers[0]} {numbers[1]}");
            else Console.WriteLine($"{numbers[1]} {numbers[0]}");
        }
    }
}
