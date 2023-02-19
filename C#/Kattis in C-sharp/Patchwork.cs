using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/patchwork

    internal struct Size
    {
        public Size(string input)
        {
            var sizeInput = input.Split(' ');
            Height = int.Parse(sizeInput[0]);
            Width = int.Parse(sizeInput[1]);
        }

        public int Height { get; }
        public int Width { get; }
    }

    internal sealed class Patchwork
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            var quiltSize = new Size(Console.ReadLine());
            var patches = GetPatches();
            var quilt = StitchPatchesOnQuilt(quiltSize, patches);
            DisplayQuilt(quilt);
        }

        private static void DisplayQuilt(char[,] quilt)
        {
            for (int i = 0; i < quilt.GetLength(0); i++)
            {
                for (int j = 0; j < quilt.GetLength(1); j++)
                {
                    Console.Write(quilt[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static char[,] StitchPatchesOnQuilt(Size quiltSize, char[][,] patches)
        {
            var quilt = CreateBlankQuilt(quiltSize);
            var numberOfPlacements = int.Parse(Console.ReadLine());
            for (int placement = 0; placement < numberOfPlacements; placement++)
            {
                var placementInput = Console.ReadLine().Split(' ');
                var y = int.Parse(placementInput[0]);
                var x = int.Parse(placementInput[1]);
                var patchNumber = int.Parse(placementInput[2]) - 1;
                var patch = patches[patchNumber];

                var rowLimit = Math.Min(quilt.GetLength(0), y + patch.GetLength(0));
                var colLimit = Math.Min(quilt.GetLength(1), x + patch.GetLength(1));
                for (int i = y; i < rowLimit; i++)
                {
                    for (int j = x; j < colLimit; j++)
                    {
                        quilt[i, j] = patch[i - y, j - x];
                    }
                }
            }
            return quilt;
        }

        private static char[,] CreateBlankQuilt(Size quiltSize)
        {
            var quilt = new char[quiltSize.Height, quiltSize.Width];
            for (int i = 0; i < quilt.GetLength(0); i++)
            {
                for (int j = 0; j < quilt.GetLength(1); j++)
                {
                    quilt[i, j] = '.';
                }
            }
            return quilt;
        }

        private static char[][,] GetPatches()
        {
            var numberOfPatches = int.Parse(Console.ReadLine());
            var patches = new char[numberOfPatches][,];
            for (int i = 0; i < numberOfPatches; i++)
            {
                patches[i] = GetPatch();
            }
            return patches;
        }

        private static char[,] GetPatch()
        {
            var patchSize = new Size(Console.ReadLine());
            var patch = new char[patchSize.Height, patchSize.Width];
            for (int i = 0; i < patchSize.Height; i++)
            {
                var row = Console.ReadLine();
                for (int j = 0; j < patchSize.Width; j++)
                {
                    patch[i, j] = row[j];
                }
            }
            return patch;
        }
    }
}
