using System;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/fizzbuzz
    internal class FizzBuzz
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var input = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            var X = input[0];
            var Y = input[1];
            var N = input[2];

            for (int i = 1; i <= N; i++)
            {
                if (i % X == 0 && i % Y == 0) Console.WriteLine("FizzBuzz");
                else if (i % X == 0) Console.WriteLine("Fizz");
                else if (i % Y == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
