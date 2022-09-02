using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/3dprinter
    class ThreeDPrinter
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var input = int.Parse(Console.ReadLine());
            var daysToPrint = Math.Ceiling(Math.Log(input, 2) + 1);
            Console.WriteLine(daysToPrint);
        }
    }
}
