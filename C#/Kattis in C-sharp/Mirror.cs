using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/mirror
    internal sealed class Mirror
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var testCases = int.Parse(Console.ReadLine());
            for (int testCaseNumber = 0; testCaseNumber < testCases; testCaseNumber++)
            {
                var sizes = Console.ReadLine().Split(new []{ ' ' }, 2);
                var rows = int.Parse(sizes[0]);
                var columns = int.Parse(sizes[1]);
                var flippedImage = GetFlippedImage(rows, columns);
                PrintImage(flippedImage, rows, columns, testCaseNumber + 1);
            }
        }

        private static char[] GetFlippedImage(int rows, int columns)
        {
            var image = new char[rows * columns];
            for (int row = 0; row < rows; row++)
            {
                var rowOfPixels = Console.ReadLine().ToCharArray();
                for (int column = 0; column < columns; column++)
                {
                    //image[row*columns + column] = rowOfPixels[column];
                    image[(rows - row) * columns - column - 1] = rowOfPixels[column];
                }
            }
            return image;
        }

        private static void PrintImage(char[] image, int rows, int columns, int testCaseNumber)
        {
            Console.WriteLine($"Test {testCaseNumber}");
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    var pixel = image[row * columns + column];
                    Console.Write(pixel);
                }
                Console.Write('\n');
            }
        }
    }
}
