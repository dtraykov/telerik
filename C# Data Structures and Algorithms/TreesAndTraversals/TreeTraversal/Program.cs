﻿namespace TreeTraversal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var nodes = new Node<int>[n];

            for (int i = 0; i < n; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 1; i < n; i++)
            {
                string edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                int parentId = int.Parse(edgeParts[0]);
                int childId = int.Parse(edgeParts[1]);

                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].HasParent = true;
            }

            // 1. Find the root
            var root = FindRoot(nodes);
            Console.WriteLine("The root of the tree is: {0}", root.Value);

            // 2. Find all leafs
            var leafs = FindAllLeafs(nodes);
            Console.Write("Leafs: ");
            foreach (var leaf in leafs)
            {
                Console.Write("{0} ", leaf.Value);
            }

            Console.WriteLine();

            // 2. Find all middle nodes
            var middleNodes = FindAllMiddleNodes(nodes);
            Console.Write("Middle nodes: ");
            foreach (var node in middleNodes)
            {
                Console.Write("{0} ", node.Value);
            }

            Console.WriteLine();

            // 4. Find longest path from the root
            var longestPath = FindLongestPath(FindRoot(nodes));
            Console.WriteLine("Longest path form the root: {0}", longestPath);
        }

        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var node in root.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
            }

            return maxPath + 1;
        }

        private static List<Node<int>> FindAllMiddleNodes(Node<int>[] nodes)
        {
            List<Node<int>> middleNodes = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.HasParent && node.Children.Count > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static List<Node<int>> FindAllLeafs(Node<int>[] nodes)
        {
            List<Node<int>> leafs = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }

        private static Node<int> FindRoot(Node<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true;
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }

            throw new ArgumentException("nodes", "The tree has now root");
        }
    }
}
