using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/patuljci
    public class Patuljci
    {
        //public static void Main() => Solution();
        
        static void Solution()
        {
           var allDwarfs = GetAllDwarfs();
           var realDwarfs = GetRealDwarfs(allDwarfs);

           Console.WriteLine(string.Join("\n", realDwarfs));
           Console.ReadLine();
        }

        public static IEnumerable<int> GetRealDwarfs(int[] dwarfs)
        {
            for (int i = 0; i < dwarfs.Length; i++)
            {
                for (int j = 1; j < dwarfs.Length - 1; j++)
                {
                    if (j == i) continue;

                    var subset = dwarfs.Where((dwarf, k) => k != i && k != j);
                    if (subset.Sum() == 100) return subset;
                }
            }
            throw new Exception("The dwarfs are fooling you");
        }

        public static int[] GetAllDwarfs()
        {
            var input = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                var dwarf = int.Parse(Console.ReadLine());
                input.Add(dwarf);
            }
            return input.ToArray();
        }
    }
}
