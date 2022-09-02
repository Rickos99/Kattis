using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/acm
    class ACM
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var problems = new (bool solved, int time)[26];

            string input;
            while ((input = Console.ReadLine()) != "-1")
            {
                var entry = input.Split(' ');
                var time = int.Parse(entry[0]);
                var problemId = entry[1][0] - 'A';
                if (!problems[problemId].solved)
                {
                    var correct = entry[2][0] == 'r';
                    problems[problemId].time += correct ? time : 20;
                    problems[problemId].solved = correct;
                }
            }

            var problemsSolved = 0;
            var score = 0;
            for (int i = 0; i < problems.Length; i++)
            {
                if (problems[i].solved)
                {
                    problemsSolved++;
                    score += problems[i].time;
                }
            }
            Console.WriteLine($"{problemsSolved} {score}");
        }
    }
}
