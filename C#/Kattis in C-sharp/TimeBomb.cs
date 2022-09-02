using System;
using System.Collections.Generic;
using System.Text;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/timebomb
    internal class TimeBomb
    {
        static readonly string[] digits = {
            "**** ** ** ****", // 0
            "  *  *  *  *  *", // 1
            "***  *****  ***", // 2
            "***  ****  ****", // 3
            "* ** ****  *  *", // 4
            "****  ***  ****", // 5
            "****  **** ****", // 6
            "***  *  *  *  *", // 7
            "**** ***** ****", // 8
            "**** ****  ****"  // 9
        };

        //public static void Main() => Solution();

        public static void Solution()
        {
            var transmission = CaptureTransmission();
            var validTransmissionCode = ValidTransmissionCode(transmission);
            Console.WriteLine(validTransmissionCode ? "BEER!!" : "BOOM!!");
        }

        static List<string> CaptureTransmission()
        {
            var rows = new List<string>(5);
            for (int i = 0; i < 5; i++)
            {
                rows.Add(Console.ReadLine());
            }
            return rows;
        }

        static bool ValidTransmissionCode(List<string> transmission)
        {
            var code = 0;
            var transmissionLength = (transmission[0].Length + 1) / 4;
            for (int i = 0; i < transmissionLength; i++)
            {
                var sb = new StringBuilder(3 * 5);
                for (int j = 0; j < 5; j++)
                {
                    var x = transmission[j].Substring(4 * i, 3);
                    sb.Append(x);
                }

                var digit = Array.IndexOf(digits, sb.ToString());
                if (digit == -1) return false;
                code += Pow(10, transmissionLength - i - 1) * digit;
            }
            return (code % 6) == 0;
        }

        static int Pow(int x, int pow)
        {
            int ret = 1;
            while (pow != 0)
            {
                if ((pow & 1) == 1)
                    ret *= x;
                x *= x;
                pow >>= 1;
            }
            return ret;
        }
    }
}
