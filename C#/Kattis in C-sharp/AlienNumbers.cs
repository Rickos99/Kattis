using System;
using System.Linq;
using System.Text;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/aliennumbers
    internal sealed class AlienNumbers
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                var input = Console.ReadLine().Split(' ');

                var x = BaseToInt(input[0], input[1]);
                var y = IntToBase(x, input[2]);
                Console.WriteLine($"Case #{i + 1}: {y}");
            }
        }

        private static int BaseToInt(string number, string language)
        {
            var base10 = 0;
            for (int i = 0; i < number.Length; i++)
            {
                base10 += language.IndexOf(number[i]) * (int)Math.Pow(language.Length, number.Length - i - 1);
            }
            return base10;
        }

        private static string IntToBase(int number, string language)
        {
            var anotherBase = new StringBuilder();
            while (number > 0)
            {
                anotherBase.Append(language[number % language.Length]);
                number = number / language.Length;
            }
            return string.Join("", anotherBase.ToString().Reverse());
        }
    }
}
