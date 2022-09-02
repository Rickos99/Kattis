using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/server
    internal class Server
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var serverTime = int.Parse(Console.ReadLine().Split(' ')[1]);
            var tasks = Console.ReadLine().Split(' ');

            var tasksTime = 0;
            var tasksDone = 0;
            for (int i = 0; i < tasks.Length; i++)
            {
                var task = int.Parse(tasks[i]);
                if (tasksTime + task > serverTime) break;
                tasksTime += task;
                tasksDone++;
            }
            Console.WriteLine(tasksDone);
        }
    }
}
