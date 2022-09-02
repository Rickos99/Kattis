using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/bryr
    internal class Bryr
    {
        //public static void Main() => Solution();

		public const int SINGLE_LANE = 1000000;

		static void Solution()
        {
            var info = Console.ReadLine().Split();
            var numberOfPositions = int.Parse(info[0]);
            var numberOfRoads = int.Parse(info[1]);

            int[,] graph = new int[numberOfPositions, numberOfPositions];
            for (; numberOfRoads > 0; numberOfRoads--)
            {
                var road = Console.ReadLine().Split(' ');
                var from = int.Parse(road[0]) - 1;
                var to = int.Parse(road[1]) - 1;
                var bridge = road[2][0] == '0' ? 1 : SINGLE_LANE;

                graph[from, to] = bridge;
                graph[to, from] = bridge;
            }

			Dijkstra.FindPath(graph, 0, numberOfPositions);
        }
    }

    class Dijkstra
    {
		private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
		{
			int min = int.MaxValue;
			int minIndex = 0;

			for (int v = 0; v < verticesCount; ++v)
			{
				if (shortestPathTreeSet[v] == false && distance[v] <= min)
				{
					min = distance[v];
					minIndex = v;
				}
			}

			return minIndex;
		}

		private static void Print(int[] distance, int verticesCount)
		{
			Console.WriteLine(distance[verticesCount - 1] / Bryr.SINGLE_LANE);
			//Console.WriteLine("Vertex    Distance from source");

			//for (int i = 0; i < verticesCount; ++i)
			//	Console.WriteLine("{0}\t  {1}", i, distance[i]);
		}

		public static void FindPath(int[,] graph, int source, int verticesCount)
		{
			int[] distance = new int[verticesCount];
			bool[] shortestPathTreeSet = new bool[verticesCount];

			for (int i = 0; i < verticesCount; ++i)
			{
				distance[i] = int.MaxValue;
				shortestPathTreeSet[i] = false;
			}

			distance[source] = 0;

			for (int count = 0; count < verticesCount - 1; ++count)
			{
				int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
				shortestPathTreeSet[u] = true;

				for (int v = 0; v < verticesCount; ++v)
					if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
						distance[v] = distance[u] + graph[u, v];
			}

			Print(distance, verticesCount);
		}

	}
}
