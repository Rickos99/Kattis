using System;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/electricaloutlets
    public static class ElectricalOutlets
    {
        //public static void Main() => Solution();

        public static void Solution()
        {
           int numberOfTestCases = int.Parse(Console.ReadLine());

           for (int i = 0; i < numberOfTestCases; i++)
           {
               Console.WriteLine(ProcessString(Console.ReadLine()));
           }
        }

        public static int ProcessString(string str)
        {
            var powerstrips = str.Split(new[] { ' ' }).Skip(1);
            return powerstrips.Sum(p => int.Parse(p) - 1) + 1;
        }
    }
}
