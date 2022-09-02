using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/findingana
    class FindingAnA
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var str = Console.ReadLine();

            var aHasBeenPassed = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (aHasBeenPassed)
                {
                    Console.Write(str[i]);
                }
                else if (str[i] == 'a')
                {
                    aHasBeenPassed = true;
                    Console.Write(str[i]);
                }
            }
        }
    }
}
