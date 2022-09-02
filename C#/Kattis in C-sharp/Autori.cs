using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/autori
    class Autori
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var reference = Console.ReadLine();

            Console.Write(reference[0]);
            for (int i = 1; i < reference.Length; i++)
            {
                if (reference[i] == '-')
                {
                    Console.Write(reference[++i]);
                }
            }
        }
    }
}
