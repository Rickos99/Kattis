using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/shopaholic
    class Shopaholic
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            _ = Console.ReadLine();

            var rawItems = Console.ReadLine().Split();
            var items = new int[rawItems.Length];
            for (int i = 0; i < rawItems.Length; i++)
                items[i] = int.Parse(rawItems[i]);
            RadixSort(items);

            var discount = 0L;
            for (int i = items.Length - 3; i >= 0; i -= 3)
            {
                discount += items[i];
            }
            Console.WriteLine(discount);
        }

        private static void RadixSort(int[] a)
        {
            int[] t = new int[a.Length];

            int r = 4;
            int b = 32;

            int[] count = new int[1 << r];
            int[] pref = new int[1 << r];

            int groups = (int)Math.Ceiling(b / (double)r);

            int mask = (1 << r) - 1;

            for (int c = 0, shift = 0; c < groups; c++, shift += r)
            {
                for (int j = 0; j < count.Length; j++)
                    count[j] = 0;

                for (int i = 0; i < a.Length; i++)
                    count[(a[i] >> shift) & mask]++;

                pref[0] = 0;
                for (int i = 1; i < count.Length; i++)
                    pref[i] = pref[i - 1] + count[i - 1];

                for (int i = 0; i < a.Length; i++)
                    t[pref[(a[i] >> shift) & mask]++] = a[i];

                t.CopyTo(a, 0);
            }
        }

    }
}
