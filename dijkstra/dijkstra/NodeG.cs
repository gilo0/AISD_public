using System.Collections.Generic;

namespace GrafApp1
{
    public class NodeG
    {
        public List<NodeG> sasiedzi = new List<NodeG>();
        public int data;

        public NodeG(int liczba)
        {
            this.data = liczba;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }
    }
}