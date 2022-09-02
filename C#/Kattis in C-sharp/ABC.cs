using System;
using System.Linq;

namespace Kattis_in_C_sharp
{
    class ABC
    {
        //public static void Main() => Solution();

        private static void Solution()
        {
           var integers = GetSortedNumbersInput();
           var chars = GetCharsInput();
           var orderedIntegers = OrderIntegersByChars(integers, chars);

           PrintResult(orderedIntegers);
        }

        private static int[] GetSortedNumbersInput()
        {
            return Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(i => i).ToArray();
        }

        private static char[] GetCharsInput()
        {
            return Console.ReadLine().ToCharArray();
        }

        private static int[] OrderIntegersByChars(int[] integers, char[] chars)
        {
            var result = new int[3];
            for (int i = 0; i < 3; i++)
            {
                result[i] = integers[chars[i] - 'A'];
            }
            return result;
        }

        private static void PrintResult(int[] integers)
        {
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
