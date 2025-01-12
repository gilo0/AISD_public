using GrafApp1;
using System;

public class PriorityQueueNode : IComparable<PriorityQueueNode>
{
    public NodeG Node { get; set; }
    public int Distance { get; set; }

    public PriorityQueueNode(NodeG node, int distance)
    {
        Node = node;
        Distance = distance;
    }

    public int CompareTo(PriorityQueueNode other)
    {
        if (other == null) return 1;
        return Distance.CompareTo(other.Distance);
    }
}
