using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/baconeggsandspam
    class BaconEggAndSpam
    {
        //public static void Main() => Solution();

        private static void Solution()
        {
            int customers;
            while ((customers = int.Parse(Console.ReadLine())) != 0)
            {
                var orders = GetOrders(customers);
                for (int i = 0; i < orders.Count; i++)
                {
                    var item = orders.ElementAt(i);
                    Console.WriteLine($"{item.Key} {string.Join(" ", item.Value.OrderBy(s => s))}");
                }
                Console.Write("\n");
            }
        }

        static SortedDictionary<string, HashSet<string>> GetOrders(int customers)
        {
            var orders = new SortedDictionary<string, HashSet<string>>();

            for (int i = 0; i < customers; i++)
            {
                var order = Console.ReadLine().Split(' ');
                for (int j = 1; j < order.Length; j++)
                {
                    if (!orders.ContainsKey(order[j]))
                    {
                        orders.Add(order[j], new HashSet<string>());
                    }
                    orders[order[j]].Add(order[0]);
                }
            }
            return orders;
        }
    }
}
