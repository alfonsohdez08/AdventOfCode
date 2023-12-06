using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day5
    {
        public static int Solve()
        {
            string[] almanac = null;

            var seeds = almanac[0].Split(':')[1].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var root = new Dictionary<int, Node>();
            foreach (var seed in seeds)
            {
                root[seed] = new Node(NodeType.Seed, seed);
            }

            var currentLevel = root;
            for (int i = 2; i < almanac.Length; i++)
            {
                int source = 1, dest = 2, rangeLength = 3;


            }

            return 0;
        }
    }

    class Node
    {
        public NodeType NodeType { get; }
        public int Key { get; }
        public List<Node> MapsTo { get; }

        public Node(NodeType nodeType, int value)
        {
            NodeType = nodeType;
            Key = value;
            MapsTo = new List<Node>();
        }
    }

    enum NodeType
    {
        Seed, Water
    }
}
