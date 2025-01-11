namespace drzewooo
{
    public partial class Form1 : Form
    {

        private BST bst = new BST();
        public Form1()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            bst.Add((int)input.Value);
            bst.DisplayTree(treeView1);
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            bst.Remove((int)input.Value);
            bst.DisplayTree(treeView1);
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            bst.Clear();
            bst.DisplayTree(treeView1);
        }
    }
}
