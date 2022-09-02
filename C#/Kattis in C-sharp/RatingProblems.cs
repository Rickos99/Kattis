using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/ratingproblems
    internal class RatingProblems
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var input = Console.ReadLine().Split(' ');
            var judges = float.Parse(input[0]);
            var k = int.Parse(input[1]);

            var sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            var max = (sum + 3 * (judges - k)) / judges;
            var min = (sum + -3 * (judges - k)) / judges;

            Console.WriteLine($"{min} {max}");
        }
    }
}
