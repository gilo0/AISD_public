using System.Collections.Generic;
using System.Linq;

namespace GrafApp1
{
    public class Graf
    {
        public List<NodeG> Nodes = new List<NodeG>();
        public List<Edge> Edges = new List<Edge>();

        public List<Edge> KruskalMST()
        {
            var mst = new List<Edge>();
            var subsets = new Dictionary<NodeG, NodeG>();

            foreach (var node in Nodes)
            {
                subsets[node] = node;
            }

            Edges.Sort();

            foreach (var edge in Edges)
            {
                var root1 = Find(subsets, edge.Start);
                var root2 = Find(subsets, edge.End);

                if (root1 != root2)
                {
                    mst.Add(edge);
                    subsets[root1] = root2;
                }
            }

            return mst;
        }

        public Dictionary<NodeG, int> Dijkstra(NodeG startNode)
        {
            var distances = Nodes.ToDictionary(node => node, node => int.MaxValue);
            distances[startNode] = 0;

            var priorityQueue = new SortedSet<PriorityQueueNode>();

            priorityQueue.Add(new PriorityQueueNode(startNode, 0));

            while (priorityQueue.Count > 0)
            {
                var current = priorityQueue.Min;
                priorityQueue.Remove(current);

                foreach (var edge in Edges.Where(e => e.Start == current.Node || e.End == current.Node))
                {
                    var neighbor = edge.Start == current.Node ? edge.End : edge.Start;
                    int newDistance = distances[current.Node] + edge.Weight;


                    if (newDistance < distances[neighbor])
                    {
                        var existingNode = priorityQueue.FirstOrDefault(n => n.Node == neighbor);
                        if (existingNode != null)
                        {
                            priorityQueue.Remove(existingNode);
                        }

                        distances[neighbor] = newDistance;
                        priorityQueue.Add(new PriorityQueueNode(neighbor, newDistance));
                    }
                }
            }

            return distances;
        }

        private NodeG Find(Dictionary<NodeG, NodeG> subsets, NodeG node)
        {
            if (subsets[node] != node)
            {
                subsets[node] = Find(subsets, subsets[node]);
            }
            return subsets[node];
        }
    }
}
