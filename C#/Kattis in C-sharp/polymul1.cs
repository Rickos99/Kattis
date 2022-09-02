using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/polymul1
    class PolyMul1
    {
        //static void Main()
        //{
        //    var tests = int.Parse(Console.ReadLine());
        //    while (tests-- > 0)
        //    {
        //        Console.ReadLine();
        //        var poly1 = Console.ReadLine();
        //        Console.ReadLine();
        //        var poly2 = Console.ReadLine();

        //        MultiplyPolynomialsAndPrint(GeneratePolyCoeffs(poly1), GeneratePolyCoeffs(poly2));
        //    }
        //}

        static int[] GeneratePolyCoeffs(string poly)
        {
            var stringCoeffs = poly.Split(' ');
            var polyCoeffs = new int[stringCoeffs.Length];

            for (int i = 0; i < stringCoeffs.Length; i++)
            {
                polyCoeffs[i] = int.Parse(stringCoeffs[i]);
            }

            return polyCoeffs;
        }

        static void MultiplyPolynomialsAndPrint(int[] a, int[] b)
        {
            var polyMatrix = GeneratePolyMatrix(a, b);
            var polyCoeffs = CalculateAntiDiagonals(polyMatrix);
            PrintPolynomialInfo(polyCoeffs);
        }

        static int[,] GeneratePolyMatrix(int[] a, int[] b)
        {
            var result = new int[a.Length, b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    result[i, j] = a[i] * b[j];
                }
            }

            return result;
        }

        static int[] CalculateAntiDiagonals(int[,] matrix)
        {
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);
            var sum = new int[rows + cols - 1];
            var sumIndex = 0;
            int r, c;

            // Calculate diagonals moving along first row
            for (int col = 0; col < cols; col++)
            {
                r = 0;
                c = col;
                while (r < rows && c >= 0)
                {
                    sum[sumIndex] += matrix[r, c];
                    c--;
                    r++;
                }
                sumIndex++;
            }

            // Calculate diagonals moving along last column, skipping first element
            for (int row = 1; row < rows; row++)
            {
                r = row;
                c = cols - 1;
                while (r < rows && c >= 0)
                {
                    sum[sumIndex] += matrix[r, c];
                    c--;
                    r++;
                }
                sumIndex++;
            }

            return sum;
        }

        static void PrintPolynomialInfo(int[] coeffs)
        {
            Console.WriteLine(coeffs.Length - 1); // Degree
            Console.WriteLine(string.Join(" ", coeffs)); // Polynomial coeffs
        }
    }
}
