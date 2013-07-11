// http://bgcoder.com/Contest/Practice/103  - 10. Енерго

namespace MinimizeTheCostForCablesBgcoder
{
    using System;
    using System.Collections.Generic;

    public class MinimizeTheCostForCablesBgcoder
    {
        public static void Main(string[] args)
        {
            List<Edge> edges = new List<Edge>();

            InitializeGraph(edges);

            edges.Sort();

            int[] tree = new int[200];
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
            int sum = 0;
            for (int i = 0; i < usedEdges.Count; i++)
            {
                sum += usedEdges[i].Weight;
            }

            Console.WriteLine(sum);
        }

        private static void InitializeGraph(List<Edge> edges)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();

                string[] argu = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] arguments = new int[argu.Length];

                for (int j = 0; j < argu.Length; j++)
                {
                    arguments[j] = int.Parse(argu[j]);
                }

                edges.Add(new Edge(arguments[0], arguments[1], arguments[2]));
            }
        }
    }

    public class Edge : IComparable<Edge>
    {
        public Edge(int startNode, int endNode, int weight)
        {
            this.StartNode = startNode;
            this.EndNode = endNode;
            this.Weight = weight;
        }

        public int StartNode { get; set; }

        public int EndNode { get; set; }

        public int Weight { get; set; }

        public int CompareTo(Edge other)
        {
            int weightCompared = this.Weight.CompareTo(other.Weight);

            if (weightCompared == 0)
            {
                return this.StartNode.CompareTo(other.StartNode);
            }

            return weightCompared;
        }

        public override string ToString()
        {
            return string.Format("({0} {1}) -> {2}", this.StartNode, this.EndNode, this.Weight);
        }
    }
}