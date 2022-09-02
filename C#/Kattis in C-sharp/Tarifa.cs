using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/tarifa
    internal class Tarifa
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var dataLimit = int.Parse(Console.ReadLine());
            var cases = int.Parse(Console.ReadLine());
            var dataQuota = 0;
            for (int i = 0; i < cases; i++)
            {
                var usage = int.Parse(Console.ReadLine());
                var dataLeft = dataLimit - usage;
                dataQuota += dataLeft;
            }
            Console.WriteLine(dataQuota + dataLimit);
            Console.ReadLine();
        }
    }
}
