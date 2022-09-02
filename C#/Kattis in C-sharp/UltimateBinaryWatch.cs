using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/ultimatebinarywatch
    internal class UltimateBinaryWatch
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var time = Console.ReadLine();
            var encodedTime = new string[time.Length];
            for (int i = 0; i < time.Length; i++)
            {
                encodedTime[i] = EncodeTime(time[i]);
            }

            DisplayTime(encodedTime);
        }

        private static string EncodeTime(char time)
        {
            switch (time)
            {
                case '0':
                    return "....";
                case '1':
                    return "...*";
                case '2':
                    return "..*.";
                case '3':
                    return "..**";
                case '4':
                    return ".*..";
                case '5':
                    return ".*.*";
                case '6':
                    return ".**.";
                case '7':
                    return ".***";
                case '8':
                    return "*...";
                case '9':
                    return "*..*";
                default:
                    throw new ArgumentOutOfRangeException(nameof(time));
            }
        }

        private static void DisplayTime(string[] encodedTime)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(encodedTime[j][i]);
                    if (j == 1) Console.Write("   ");
                    else if (j != 3) Console.Write(' ');
                }
                Console.Write('\n');
            }
        }
    }
}
