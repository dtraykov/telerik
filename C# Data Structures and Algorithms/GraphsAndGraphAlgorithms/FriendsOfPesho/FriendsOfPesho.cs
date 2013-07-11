namespace FriendsOfPesho
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public struct Node : IComparable<Node>
    {
        public int Vertex { get; set; }

        public int Disntace { get; set; }

        public int CompareTo(Node other)
        {
            return this.Disntace.CompareTo(other.Disntace);
        }
    }

    public class FriendsOfPesho
    {
        public static void Main()
        {
            string[] nMH = ReadConsoleLine();
            int n = int.Parse(nMH[0]);
            int m = int.Parse(nMH[1]);
            int h = int.Parse(nMH[2]);

            Graph graph = new Graph(n);
            string[] hospitals = ReadConsoleLine();
            AddHospitalsToGraph(graph, hospitals);
            ReadEdges(m, graph);

            int sum = graph.GetBestHospital();
            Console.WriteLine(sum);
        }

        private static string[] ReadConsoleLine()
        {
            string inputLine = Console.ReadLine();
            string[] hospitals = inputLine.Split(' ');
            return hospitals;
        }

        private static void ReadEdges(int m, Graph graph)
        {
            for (int i = 0; i < m; i++)
            {
                string[] edgeArguments = ReadConsoleLine();
                int from = int.Parse(edgeArguments[0]);
                int to = int.Parse(edgeArguments[1]);
                int distance = int.Parse(edgeArguments[2]);
                graph.AddEdge(from, to, distance);
            }
        }

        private static void AddHospitalsToGraph(Graph graph, string[] hospitals)
        {
            foreach (var hospitalAsString in hospitals)
            {
                int hospital = int.Parse(hospitalAsString);
                graph.AddHospital(hospital);
            }
        }
    }

    public class Graph
    {
        private List<Node>[] vertices;
        private HashSet<int> hospitals;
        private OrderedBag<Node> pQueue;
        private HashSet<int> used;
        private int[] distances;

        public Graph(int n)
        {
            this.vertices = new List<Node>[n];
            this.hospitals = new HashSet<int>();
        }

        public void AddEdge(int from, int to, int distance)
        {
            this.AddDirectedEdge(from - 1, to - 1, distance);
            this.AddDirectedEdge(to - 1, from - 1, distance);
        }

        public void AddHospital(int hospital)
        {
            this.hospitals.Add(hospital - 1);
        }

        public int GetBestHospital()
        {
            int bestDistance = int.MaxValue;

            foreach (int hospital in this.hospitals)
            {
                int[] distances = this.Dijkstra(hospital);
                int distance = this.Sum(distances);
                if (distance < bestDistance)
                {
                    bestDistance = distance;
                }
            }

            return bestDistance;
        }

        private int Sum(int[] distances)
        {
            int sum = 0;
            for (int vertex = 0; vertex < distances.Length; vertex++)
            {
                if (!this.hospitals.Contains(vertex))
                {
                    sum += distances[vertex];
                }
            }

            return sum;
        }

        private void AddDirectedEdge(int from, int to, int distance)
        {
            if (this.vertices[from] == null)
            {
                this.vertices[from] = new List<Node>();
            }

            var newNode = new Node()
            {
                Vertex = to,
                Disntace = distance,
            };
            this.vertices[from].Add(newNode);
        }

        private int[] Dijkstra(int hospital)
        {
            this.InitializeQueue();
            this.InitializeUsed();
            this.InitializeDistances(hospital);
            this.used.Add(hospital);
            Node startNode = new Node()
            {
                Vertex = hospital,
                Disntace = 0,
            };

            this.pQueue.Add(startNode);
            Node best;
            while (this.pQueue.Count > 0)
            {
                best = this.pQueue.GetFirst();
                this.pQueue.RemoveFirst();
                this.used.Add(best.Vertex);
                foreach (var nextNode in this.vertices[best.Vertex])
                {
                    int newDistance = this.distances[best.Vertex] + nextNode.Disntace;
                    if (this.distances[nextNode.Vertex] > newDistance)
                    {
                        this.distances[nextNode.Vertex] = newDistance;
                        Node next = new Node()
                        {
                            Vertex = nextNode.Vertex,
                            Disntace = newDistance
                        };

                        this.pQueue.Add(next);
                    }
                }

                this.ClearUsedVerticesFromQueue();
            }

            return this.distances;
        }

        private void InitializeDistances(int hospital)
        {
            if (this.distances == null)
            {
                this.distances = new int[this.vertices.Length];
            }

            for (int i = 0; i < this.distances.Length; i++)
            {
                this.distances[i] = int.MaxValue;
            }

            this.distances[hospital] = 0;
        }

        private void ClearUsedVerticesFromQueue()
        {
            while (this.pQueue.Count > 0 && this.used.Contains(this.pQueue.GetFirst().Vertex))
            {
                this.pQueue.GetFirst();
                this.pQueue.RemoveFirst();
            }
        }

        private void InitializeUsed()
        {
            if (this.used == null)
            {
                this.used = new HashSet<int>();
            }
            else
            {
                this.used.Clear();
            }
        }

        private void InitializeQueue()
        {
            if (this.pQueue == null)
            {
                this.pQueue = new OrderedBag<Node>();
            }
            else
            {
                this.pQueue.Clear();
            }
        }
    }
}