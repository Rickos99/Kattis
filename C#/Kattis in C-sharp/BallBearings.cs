using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/ballbearings
    class BallBearings
    {
        //public static void Main() => Solution();

        public static void Solution()
        {
           int testCases = int.Parse(Console.ReadLine());
           int[] results = new int[testCases];
           for (int i = 0; i < results.Length; i++)
           {
               string[] values = Console.ReadLine().Split(' ');
               float D = float.Parse(values[0]);
               float d = float.Parse(values[1]);
               float s = float.Parse(values[2]);

               results[i] = CalculateFittedBallsInBearing(D, d, s);
           }

           Console.Write(string.Join("\n", results));
        }

        public static int CalculateFittedBallsInBearing(float D, float d, float s)
        {
            double R = D / 2;
            double r = d / 2;
            double angle = Math.Acos(1 - Math.Pow(s + 2 * r, 2) / (2 * Math.Pow(R - r, 2)));
            return (int)(2 * Math.PI / angle);
        }
    }
}
