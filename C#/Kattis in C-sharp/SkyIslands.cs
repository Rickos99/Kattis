using System;
using System.Collections.Generic;

namespace Kattis_in_C_sharp.SkyIslands
{
    // https://open.kattis.com/problems/skyislands
    internal class BFSNode
    {
        public readonly int Id;

        public List<BFSNode> Adj;
        public Color Color;

        public BFSNode(int Id) { 
            this.Id = Id;
            this.Adj = new List<BFSNode>();
            this.Color = Color.WHITE;
        }
    }

    internal enum Color
    {
        WHITE, GRAY, BLACK
    }

    class SkyIslands
    {

        //public static void Main() => Solution();

        static void Solution()
        {
            (int islands, int bridges) = GetIntegerTuple();
            var Q = new Queue<BFSNode>(islands);
            var G = new BFSNode[islands];
            for (int i = 0; i < G.Length; i++)
            {
                G[i] = new BFSNode(i);
            }

            for (int i = 0; i < bridges; i++)
            {
                (int a, int b) = GetIntegerTuple();
                a--; b--;
                G[a].Adj.Add(G[b]);
                G[b].Adj.Add(G[a]);
            }

            G[0].Color = Color.GRAY;
            Q.Enqueue(G[0]);
            while (Q.Count > 0)
            {
                var u = Q.Dequeue();
                foreach (var v in u.Adj)
                {
                    if (v.Color == Color.WHITE)
                    {
                        v.Color = Color.GRAY;
                        Q.Enqueue(v);
                    }
                }
                u.Color = Color.BLACK;
            }

            var connected = true;
            for (int i = 0; i < G.Length; i++)
            {
                if (G[i].Color != Color.BLACK)
                {
                    connected = false;
                    break;
                }
            }

            Console.WriteLine(connected ? "YES" : "NO");
        }

        private static (int a, int b) GetIntegerTuple()
        {
            var metadata = Console.ReadLine().Split();
            return (int.Parse(metadata[0]), int.Parse(metadata[1]));
        }
    }
}
