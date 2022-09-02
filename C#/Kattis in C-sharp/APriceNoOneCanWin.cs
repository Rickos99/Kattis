using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/aprizenoonecanwin
    class APriceNoOneCanWin
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var maxPrize = int.Parse(Console.ReadLine().Split(' ')[1]);
            var items = Console.ReadLine()
                .Split(' ')
                .Select(i => int.Parse(i))
                .ToList();

            Console.WriteLine(CalculateItemsForSale(items, maxPrize));
        }

        static int CalculateItemsForSale(List<int> items, int maxPrize)
        {
            if (items.Count == 1)
            {
                return 1;
            }

            items.Sort();

            for (int i = 1; i < items.Count; i++)
            {
                if (items[i - 1] + items[i] > maxPrize) return i;
            }
            return items.Count;
        }
    }
}
