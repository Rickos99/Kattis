using System;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/cups
    internal struct Cup
    {
        public int Diameter { get; }
        public string Color { get; }

        public Cup(int diameter, string color)
        {
            Diameter = diameter;
            Color = color;
        }
    }

    class StackingCups
    {
        //public static void Main() => Solution();

        static void Solution()
        {
           var input = GetInput();
           var cups = ParseCups(input);
           var OrderedCups = cups.OrderBy(c => c.Diameter).Select(c => c.Color);
           Console.WriteLine(string.Join("\n", OrderedCups));
           Console.ReadLine();
        }

        private static string[] GetInput()
        {
            var numberOfCups = int.Parse(Console.ReadLine());
            var input = new string[numberOfCups];
            for (int i = 0; i < numberOfCups; i++)
            {
                input[i] = Console.ReadLine();
            }
            return input;
        }

        private static Cup[] ParseCups(string[] cupStrings)
        {
            var cups = new Cup[cupStrings.Length];
            for (int i = 0; i < cupStrings.Length; i++)
            {
                var cupProperties = cupStrings[i].Split(' ');

                if (char.IsDigit(cupProperties[0][0]))
                {
                    cups[i] = new Cup(int.Parse(cupProperties[0]), cupProperties[1]);
                }
                else
                {
                    cups[i] = new Cup(int.Parse(cupProperties[1]) * 2, cupProperties[0]);
                }

            }
            return cups;
        }
    }
}
