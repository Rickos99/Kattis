using System;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/addtwonumbers
    class AddTwoNumbers
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            Console.WriteLine(
                Console.ReadLine()
                       .Split(' ')
                       .Select(i => int.Parse(i))
                       .Sum()
                );
        }
    }
}
