using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/speedlimit
    internal class SpeedLimit
    {
        //public static void Main() => Solution();
        
        static void Solution()
        {
           string input;
           while ((input = Console.ReadLine()) != "-1")
           {
               var triplog = GetTripLog(int.Parse(input));
               var distance = CalculateDistance(triplog);
               Console.WriteLine($"{distance} miles");
           }
        }

        private static List<(int speed, int duration)> GetTripLog(int entries)
        {
            var log = new List<(int speed, int duration)>();
            var totalDuration = 0;
            for (int i = 0; i < entries; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();
                var speed = input[0];
                var duration = input[1] - totalDuration;
                totalDuration = input[1];

                log.Add((speed, duration));
            }
            return log;
        }

        private static int CalculateDistance(List<(int speed, int duration)> triplog)
        {
            int distance = 0;
            foreach (var entry in triplog)
            {
                distance += entry.speed * entry.duration;
            }
            return distance;
        }
    }
}
