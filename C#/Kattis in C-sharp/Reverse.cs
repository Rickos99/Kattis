using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/ofugsnuid
    class Reverse
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            int lines = int.Parse(Console.ReadLine());
            string[] reverseInputs = new string[lines];
            while (lines-- > 0)
            {
                string line = Console.ReadLine();
                reverseInputs[lines] = line;
            }
            Console.Write(string.Join("\n", reverseInputs));
        }
    }
}
