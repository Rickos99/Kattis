using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/julmust
    internal class Julmust
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var upperLimit = int.Parse(Console.ReadLine());
            var lowerLimit = 0;
            int response = -1;

            int day = 0;
            while (response != 0)
            {
                int guess = (lowerLimit + upperLimit) / 2;
                Console.WriteLine(guess * (day + 1));

                response = DecodeResponse(Console.ReadLine());

                if (response < 0)
                {
                    upperLimit = guess - 1;
                }
                else
                {
                    lowerLimit = guess + 1;
                }
                day++;
            }
        }

        static int DecodeResponse(string response)
        {
            switch (response)
            {
                case "less":
                    return -1;
                case "exact":
                    return 0;
                case "more":
                    return 1;
                default:
                    return int.MaxValue;
            }
        }
    }
}
