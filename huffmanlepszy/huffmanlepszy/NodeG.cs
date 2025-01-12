using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huffmanlepszy
{
    internal class NodeG
    {
        public NodeG Lewy { get; set; }
        public NodeG Prawy { get; set; }
        public int Data { get; set; }

        public bool CzyLiść => Lewy == null && Prawy == null;
    }
}
