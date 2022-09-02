using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/averagecharacter
    class AverageCharacter
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var input = Console.ReadLine();
            var sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            Console.WriteLine((char)(sum / (input.Length * 1d)));
        }
    }
}
