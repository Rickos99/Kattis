using System;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/aboveaverage
    class AboveAverage
    {
        //public static void Main() => Solution();

        private void Solution
        ()
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                Console.WriteLine(ComputeCase());
            }
            Console.ReadLine();
        }

        private string ComputeCase()
        {
            // Get line as a string
            string line = Console.ReadLine();

            // Parse line into an array of integers
            int[] rawData = line.Split(new char[] { ' ' }).Select(int.Parse).ToArray();

            // Calculate the average and the number of entries grater than average
            double average = rawData.Skip(1).Sum() * 1.0 / rawData[0];
            double aboveAverage = rawData.Skip(1).Where(entry => entry > average).ToArray().Length / (rawData[0] * 1.0);

            // Return number as a string with exactly 3 decimals and ends with %
            return RoundTo3Decimals(aboveAverage) + '%';
        }

        private string RoundTo3Decimals(double number)
        {
            string result = (number * 100).ToString("#.000");
            if (result.Substring(0, 1).Equals(".") || result.Substring(0, 1).Equals(","))
            {
                result = '0' + result;
            }
            return result;
        }
    }
}
