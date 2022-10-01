using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/yoda
    class Yoda
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            while (str1.Length != str2.Length)
            {
                if (str1.Length < str2.Length)
                    str1 = '0' + str1;
                else
                    str2 = '0' + str2;
            }


            for (int i = str1.Length - 1; i >= 0; i--)
            {
                if (str1[i] < str2[i])
                    str1 = str1.Remove(i, 1);
                else if (str1[i] > str2[i])
                    str2 = str2.Remove(i, 1);
            }

            Console.WriteLine(str1.Length == 0 ? "YODA" : int.Parse(str1).ToString());
            Console.WriteLine(str2.Length == 0 ? "YODA" : int.Parse(str2).ToString());
        }
    }
}
