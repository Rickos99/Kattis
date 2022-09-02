using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/easiest
    internal class Easiest
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            int input;
            while ((input = int.Parse(Console.ReadLine())) != 0)
            {
                Console.WriteLine(GetMValue(input));
            }
        }

        internal static int GetMValue(int input)
        {
            var sodInput = SumOfDigits(input);
            for (int m = 11; ; m++)
            {
                if (SumOfDigits(input * m) == sodInput)
                {
                    return m;
                }
            }
        }

        internal static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
