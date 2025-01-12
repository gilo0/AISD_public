namespace huffmanlepszy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Dictionary<char, int> SymbolFrequency = new Dictionary<char, int>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputBox.Text.Length != 1)
                {
                    throw new ArgumentException("Wpisz 1 znak");
                }

                char znak = char.ToLower(InputBox.Text[0]);
                if (!SymbolFrequency.ContainsKey(znak))
                {
                    SymbolFrequency[znak] = 0;
                }
                SymbolFrequency[znak]++;

                var sortedDictionary = SymbolFrequency.OrderBy(kvp => kvp.Key);
                textBox2.Text = string.Join(Environment.NewLine, sortedDictionary.Select(kvp => $"{kvp.Key}: {kvp.Value}" + ", "));
                InputBox.Text = "";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SymbolFrequency.Clear();
            InputBox.Text = "";
            textBox2.Text = "";
            TreeDisplay.Nodes.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (SymbolFrequency.Count == 0)
                {
                    MessageBox.Show("Słownik jest pusty");
                    return;
                }

                var korzeń = BuildHuffmanTree(SymbolFrequency);

                TreeDisplay.Nodes.Clear();
                DisplayTree(korzeń, TreeDisplay.Nodes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message);
            }
        }
        private NodeG BuildHuffmanTree(Dictionary<char, int> frequencies)
        {
            var nodes = new List<NodeG>();

            foreach (var pair in frequencies)
            {
                nodes.Add(new NodeGS { Symbol = pair.Key, Data = pair.Value });
            }

            while (nodes.Count > 1)
            {
                nodes = nodes.OrderBy(n => n.Data).ToList();

                var lewy = nodes[0];
                var prawy = nodes[1];
                nodes.RemoveRange(0, 2);

                var rodzic = new NodeG
                {
                    Lewy = lewy,
                    Prawy = prawy,
                    Data = lewy.Data + prawy.Data
                };

                nodes.Add(rodzic);
            }
            return nodes[0];
        }
        private void DisplayTree(NodeG node, TreeNodeCollection treeNodes)
        {
            if (node == null) return;

            var text = node is NodeGS leaf
                ? $"{leaf.Symbol} ({leaf.Data})"
                : $"[{node.Data}]";

            var treeNode = new TreeNode(text);
            treeNodes.Add(treeNode);

            DisplayTree(node.Lewy, treeNode.Nodes);
            DisplayTree(node.Prawy, treeNode.Nodes);
        }
    }
}
