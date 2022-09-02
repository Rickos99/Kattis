using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/qaly
    internal class Qaly
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var cases = int.Parse(Console.ReadLine());

            var qaly = 0f;
            for (; cases > 0; cases--)
            {
                var line = Console.ReadLine().Split(' ');
                qaly += float.Parse(line[0])*float.Parse(line[1]);
            }
            Console.WriteLine(qaly);
        }
    }
}
