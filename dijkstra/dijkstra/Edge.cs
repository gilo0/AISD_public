using System;

namespace GrafApp1
{
    public class Edge : IComparable<Edge>
    {
        public NodeG Start { get; set; }
        public NodeG End { get; set; }
        public int Weight { get; set; }

        public Edge(NodeG start, NodeG end, int weight)
        {
            Start = start;
            End = end;
            Weight = weight;
        }

        public int CompareTo(Edge other)
        {
            return Weight.CompareTo(other.Weight);
        }

        public override string ToString()
        {
            return $"{Start.data} - {End.data} ({Weight})";
        }
    }
}
