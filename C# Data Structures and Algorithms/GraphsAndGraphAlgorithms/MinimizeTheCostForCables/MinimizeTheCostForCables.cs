namespace MinimizeTheCostForCablesBgcoder
{
    using System;
    using System.Collections.Generic;

    public class MinimizeTheCostForCables
    {
        public static void Main(string[] args)
        {
            int numberOfNodes = 6;
            List<Edge> edges = new List<Edge>();

            InitializeGraph(edges);

            edges.Sort();

            int[] tree = new int[numberOfNodes + 1];
            List<Edge> mpd = new List<Edge>();
            int treesCount = 1;

            treesCount = FindMinimumSpanningTree(edges, tree, mpd, treesCount);

            PrintMinimumSpanningTree(mpd);
        }

        private static int FindMinimumSpanningTree(List<Edge> edges, int[] tree, List<Edge> mpd, int treesCount)
        {
            foreach (var edge in edges)
            {
                if (tree[edge.StartNode] == 0)
                {
                    if (tree[edge.EndNode] == 0)
                    {
                        tree[edge.StartNode] = tree[edge.EndNode] = treesCount;
                        treesCount++;
                    }
                    else
                    {
                        tree[edge.StartNode] = tree[edge.EndNode];
                    }

                    mpd.Add(edge);
                }
                else
                {
                    if (tree[edge.EndNode] == 0)
                    {
                        tree[edge.EndNode] = tree[edge.StartNode];
                        mpd.Add(edge);
                    }
                    else if (tree[edge.EndNode] != tree[edge.StartNode])
                    {
                        int oldTreeNumber = tree[edge.EndNode];

                        for (int i = 0; i < tree.Length; i++)
                        {
                            if (tree[i] == oldTreeNumber)
                            {
                                tree[i] = tree[edge.StartNode];
                            }
                        }

                        mpd.Add(edge);
                    }
                }
            }

            return treesCount;
        }

        private static void PrintMinimumSpanningTree(List<Edge> usedEdges)
        {
            foreach (var edge in usedEdges)
            {
                Console.WriteLine(edge);
            }
        }

        private static void InitializeGraph(List<Edge> edges)
        {
            edges.Add(new Edge(1, 3, 5));
            edges.Add(new Edge(1, 2, 4));
            edges.Add(new Edge(1, 4, 9));
            edges.Add(new Edge(2, 4, 2));
            edges.Add(new Edge(3, 4, 20));
            edges.Add(new Edge(5, 6, 12));
        }
    }
}