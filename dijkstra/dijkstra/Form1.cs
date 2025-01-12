using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GrafApp1
{
    public partial class Form1 : Form
    {
        private Graf graf = new Graf();
        private Dictionary<int, NodeG> nodesDict = new Dictionary<int, NodeG>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddNodeButton_Click(object sender, EventArgs e)
        {
            int nodeValue = nodesDict.Count;
            NodeG newNode = new NodeG(nodeValue);
            nodesDict[nodeValue] = newNode;
            graf.Nodes.Add(newNode);

            graphDisplay.Refresh();
        }

        private void AddEdgeButton_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Podaj 2 wezly i wage krawedzi po przecinku", "Dodaj Krawedz");
            var values = input.Split(',');

            if (values.Length != 3 || !int.TryParse(values[0], out int node1) || !int.TryParse(values[1], out int node2) || !int.TryParse(values[2], out int weight))
            {
                MessageBox.Show("Niepoprawne dane");
                return;
            }

            var edge = new Edge(nodesDict[node1], nodesDict[node2], weight);
            graf.Edges.Add(edge);

            nodesDict[node1].sasiedzi.Add(nodesDict[node2]);
            nodesDict[node2].sasiedzi.Add(nodesDict[node1]);

            graphDisplay.Refresh();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            graf = new Graf();
            nodesDict.Clear();
            graphDisplay.Refresh();
        }

        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var mstEdges = graf.KruskalMST();

            foreach (var edge in graf.Edges)
            {
                g.DrawLine(Pens.Gray, GetNodePosition(edge.Start), GetNodePosition(edge.End));
            }

            foreach (var edge in mstEdges)
            {
                g.DrawLine(Pens.Red, GetNodePosition(edge.Start), GetNodePosition(edge.End));
            }

            foreach (var node in graf.Nodes)
            {
                var position = GetNodePosition(node);
                g.FillEllipse(Brushes.Orange, position.X - 15, position.Y - 15, 30, 30);
                g.DrawEllipse(Pens.Black, position.X - 15, position.Y - 15, 30, 30);
                g.DrawString(node.data.ToString(), new Font("Times New Roman", 12), Brushes.Black, position.X - 8, position.Y - 8);
            }
        }

        private Point GetNodePosition(NodeG node)
        {
            int index = graf.Nodes.IndexOf(node);
            int radius = 200;
            int centerX = graphDisplay.Width / 2;
            int centerY = graphDisplay.Height / 2;
            double angle = 2 * Math.PI * index / graf.Nodes.Count;

            int x = centerX + (int)(radius * Math.Cos(angle));
            int y = centerY + (int)(radius * Math.Sin(angle));
            return new Point(x, y);
        }

        private void DijkstraButton_Click(object sender, EventArgs e)
        {
            if (nodesDict.Count == 0)
            {
                MessageBox.Show("Graf jest pusty");
                return;
            }

            string input = Microsoft.VisualBasic.Interaction.InputBox("Podaj numer wezla poczatkowego:", "Dijkstra");

            if (!int.TryParse(input, out int startNode) || !nodesDict.ContainsKey(startNode))
            {
                MessageBox.Show("Nieprawidlowy wezel poczatkowy");
                return;
            }

            var start = nodesDict[startNode];
            var distances = graf.Dijkstra(start);

            string result = "Najkrotsze odleglosci do wezla " + startNode + ":\n";
            foreach (var kvp in distances)
            {
                result += $"Do wezla: {kvp.Key.data}: {kvp.Value}\n";
            }

            MessageBox.Show(result, "Wyniki");
        }
    }
}