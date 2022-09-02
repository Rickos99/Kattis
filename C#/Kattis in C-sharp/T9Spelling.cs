using System;
using System.Text;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/t9spelling
    internal class T9Spelling
    {
        private static readonly string[] encodings =
        {
            "2",
            "22",
            "222",
            "3",
            "33",
            "333",
            "4",
            "44",
            "444",
            "5",
            "55",
            "555",
            "6",
            "66",
            "666",
            "7",
            "77",
            "777",
            "7777",
            "8",
            "88",
            "888",
            "9",
            "99",
            "999",
            "9999"
        };

        //public static void Main() => Solution();

        static void Solution()
        {
           var cases = int.Parse(Console.ReadLine());
           for (int i = 0; i < cases; i++)
           {
               var message = Console.ReadLine();
               Console.WriteLine($"Case #{i + 1}: {encodeMessage(message)}");
           }
        }

        static string encodeMessage(string message)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                var c = message[i];
                if (c == ' ')
                {
                    if (sb.Length != 0 && sb[sb.Length - 1] == '0') sb.Append(' ');
                    sb.Append("0");
                }
                else
                {
                    var encoding = encodings[c - 'a'];
                    if (sb.Length != 0 && sb[sb.Length - 1] == encoding[0]) sb.Append(' ');
                    sb.Append(encoding);
                }
            }
            return sb.ToString();
        }
    }
}
