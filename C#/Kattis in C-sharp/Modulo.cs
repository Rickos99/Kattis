using System;
using System.Collections.Generic;

namespace Kattis_in_C_sharp
{
    class Modulo
    {
        // https://open.kattis.com/problems/modulo

        //public static void Main() => Solution();

        static void Solution()
        {
            List<int> remainders = new List<int>();
            string line;
            while ((line = Console.ReadLine()) != string.Empty)
            {
                bool succesfulParseOfine = int.TryParse(line, out int number);
                if (!succesfulParseOfine)
                    break;
                int remainder = number % 42;
                if (!remainders.Contains(remainder))
                {
                    remainders.Add(remainder);
                }
            }
            Console.WriteLine(remainders.Count);
            Console.ReadLine();
        }
    }
}
