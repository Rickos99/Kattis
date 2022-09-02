using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/heimavinna
    class Heimavinna
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var problems = Console.ReadLine().Split(';');

            var numberOfProblems = 0;
            for (int i = 0; i < problems.Length; i++)
            {
                var problemSplit = problems[i].Split('-');
                if (problemSplit.Length == 1) numberOfProblems++;
                else
                {
                    numberOfProblems += int.Parse(problemSplit[1]) - int.Parse(problemSplit[0]) + 1;
                }
            }
            Console.WriteLine(numberOfProblems);
        }
    }
}
