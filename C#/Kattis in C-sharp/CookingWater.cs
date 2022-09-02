using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/cookingwater
    internal class CookingWater
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var cases = int.Parse(Console.ReadLine());

            var min = int.MinValue;
            var max = int.MaxValue;
            for (int i = 0; i < cases; i++)
            {
                var range = Console.ReadLine().Split(' ');
                var rangeMin = int.Parse(range[0]);
                var rangeMax = int.Parse(range[1]);

                if (rangeMin > min) min = rangeMin;
                if (rangeMax < max) max = rangeMax;
            }

            Console.WriteLine(min <= max ? "gunilla has a point" : "edward is right");
        }
    }
}
