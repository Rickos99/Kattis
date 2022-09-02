using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/weakvertices
    internal class WeakVertices
    {
        //public static void Main() => Solution();

        static void Solution()
        {
            int vertices;
            while ((vertices = int.Parse(Console.ReadLine())) != -1)
            {
                Console.WriteLine(string.Join(" ", RunCase(vertices)));
            }
        }

        private static int[] RunCase(int vertices)
        {
            var g = GetGraph(vertices);
            var weakVertices = new List<int>(vertices / 4);

            if (vertices < 3) return Enumerable.Range(0, vertices).ToArray();

            for (int i = 0; i < vertices; i++)
            {
                var vertexIsWeak = true;
                for (int j = 0; j < vertices; j++)
                {
                    for (int k = 0; k < vertices; k++)
                    {
                        if (g[i, j] == 1 && g[j, k] == 1 && g[k, i] == 1)
                        {
                            vertexIsWeak = false;
                            goto end_jth_loop;
                        }
                    }
                }
                end_jth_loop:

                if (vertexIsWeak)
                {
                    weakVertices.Add(i);
                }
            }
            return weakVertices.ToArray();
        }

        private static int[,] GetGraph(int vertices)
        {
            var g = new int[vertices, vertices];
            for (int i = 0; i < vertices; i++)
            {
                var row = Console.ReadLine().Split();
                for (int j = 0; j < vertices; j++)
                {
                    g[i, j] = int.Parse(row[j]);
                }
            }

            return g;
        }
    }
}
