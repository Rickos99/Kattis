using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/bard
    class Bard
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var N = int.Parse(Console.ReadLine());
            var E = int.Parse(Console.ReadLine());
            var villagers = new HashSet<int>[N];
            var songs = 0;

            for (int i = 0; i < villagers.Length; i++)
            {
                villagers[i] = new HashSet<int>();
            }

            while (E-- > 0)
            {
                var participants = GetParticipants();
                if (participants.Contains(1))
                {
                    for (int i = 0; i < participants.Length; i++)
                    {
                        villagers[participants[i] - 1].Add(E);
                    }
                    songs++;
                }
                else
                {
                    var k = new HashSet<int>();
                    for (int i = 0; i < participants.Length; i++)
                    {
                        if (participants[i] == 1) continue;
                        k.UnionWith(villagers[participants[i] - 1]);
                    }

                    for (int i = 0; i < participants.Length; i++)
                    {
                        villagers[participants[i] - 1].UnionWith(k);
                    }
                }
            }

            Console.WriteLine(1);
            for (int i = 1; i < villagers.Length; i++)
            {
                if (villagers[i].Count == songs) Console.WriteLine(i + 1);
            }
        }

        private static int[] GetParticipants()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, 2)[1].Split();
            var participants = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
                participants[i] = int.Parse(input[i]);
            return participants;
        }
    }
}
