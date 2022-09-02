using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/gold
    internal struct MapPosition
    {
        public int Row { get; }
        public int Col { get; }

        public MapPosition Up => new MapPosition(Row + 1, Col);
        public MapPosition Down => new MapPosition(Row - 1, Col);
        public MapPosition Right => new MapPosition(Row, Col + 1);
        public MapPosition Left => new MapPosition(Row, Col - 1);

        public MapPosition(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }

    class Gold
    {
        //public static void Main() => Solution();

        public static void Solution()
        {
           var map = RetrieveMap();
           var reachableGold = GetNumberOfReachableGold(map.map, map.playerPosition);
           Console.WriteLine(reachableGold);
        }

        static (char[][] map, MapPosition playerPosition) RetrieveMap()
        {
            var h = int.Parse(Console.ReadLine().Split(' ')[1]);

            var map = new char[h][];
            MapPosition playerPosition = new MapPosition();
            for (int i = 0; i < map.Length; i++)
            {
                var row = Console.ReadLine().ToCharArray();
                var indexOfP = Array.IndexOf(row, 'P');
                if (indexOfP != -1) playerPosition = new MapPosition(i, indexOfP);
                map[i] = row;
            }
            return (map, playerPosition);
        }

        static int GetNumberOfReachableGold(char[][] map, MapPosition playerPosition)
        {
            var visitedPositions = new bool[map.Length, map[0].Length];
            var positionQueue = new Queue<MapPosition>();
            var reachableGold = 0;

            positionQueue.Enqueue(playerPosition);
            while (positionQueue.Any())
            {
                var currentPosition = positionQueue.Dequeue();
                var positionSymbol = map[currentPosition.Row][currentPosition.Col];
                if (positionSymbol == 'G') reachableGold++;

                var up = currentPosition.Up;
                var right = currentPosition.Right;
                var down = currentPosition.Down;
                var left = currentPosition.Left;

                // Take a step back if any nearby position is a trap
                if (PositionIsATrap(map, up) || PositionIsATrap(map, right) || PositionIsATrap(map, down) || PositionIsATrap(map, left)) continue;

                // Up
                if (PositionShouldBeVisited(map, visitedPositions, up))
                {
                    positionQueue.Enqueue(up);
                    visitedPositions[up.Row, up.Col] = true;
                }

                // Right
                if (PositionShouldBeVisited(map, visitedPositions, right))
                {
                    positionQueue.Enqueue(right);
                    visitedPositions[right.Row, right.Col] = true;
                }

                // Down
                if (PositionShouldBeVisited(map, visitedPositions, down))
                {
                    positionQueue.Enqueue(down);
                    visitedPositions[down.Row, down.Col] = true;
                }

                // Left
                if (PositionShouldBeVisited(map, visitedPositions, left))
                {
                    positionQueue.Enqueue(left);
                    visitedPositions[left.Row, left.Col] = true;
                }
            }
            return reachableGold;
        }

        static bool PositionIsATrap(char[][] map, MapPosition pos)
        {
            return map[pos.Row][pos.Col] == 'T';
        }

        static bool PositionShouldBeVisited(char[][] map, bool[,] visitedPositions, MapPosition pos)
        {
            var posSymbol = map[pos.Row][pos.Col];
            return (posSymbol == '.' || posSymbol == 'G') && !visitedPositions[pos.Row, pos.Col];
        }
    }
}
